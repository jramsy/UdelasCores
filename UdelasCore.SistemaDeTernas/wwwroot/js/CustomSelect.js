        class CustomSelect {
            constructor(element, options = {}) {
                this.element = element;
                this.options = {
                    placeholder: 'Selecciona una opción',
                    searchable: true,
                    multiple: element.hasAttribute('multiple'),
                    allowClear: true,
                    ajax: null,
                    minimumInputLength: 0,
                    ...options
                };
                
                this.isOpen = false;
                this.selectedValues = [];
                this.filteredOptions = [];
                
                this.init();
            }

            init() {
                this.createCustomSelect();
                this.bindEvents();
                this.updateDisplay();
                
                // Ocultar el select original
                this.element.style.display = 'none';
            }

            createCustomSelect() {
                // Crear container principal
                this.container = document.createElement('div');
                this.container.className = 'custom-select';
                
                // Crear trigger
                this.trigger = document.createElement('div');
                this.trigger.className = 'custom-select-trigger';
                this.trigger.innerHTML = `
                    <div class="custom-select-value"></div>
                    <div class="custom-select-arrow"></div>
                `;
                
                // Crear dropdown
                this.dropdown = document.createElement('div');
                this.dropdown.className = 'custom-select-dropdown';
                
                if (this.options.searchable) {
                    this.searchContainer = document.createElement('div');
                    this.searchContainer.className = 'custom-select-search';
                    this.searchInput = document.createElement('input');
                    this.searchInput.type = 'text';
                    this.searchInput.placeholder = 'Buscar...';
                    this.searchContainer.appendChild(this.searchInput);
                    this.dropdown.appendChild(this.searchContainer);
                }
                
                this.optionsContainer = document.createElement('div');
                this.optionsContainer.className = 'custom-select-options';
                this.dropdown.appendChild(this.optionsContainer);
                
                // Ensamblar
                this.container.appendChild(this.trigger);
                this.container.appendChild(this.dropdown);
                
                // Insertar después del select original
                this.element.parentNode.insertBefore(this.container, this.element.nextSibling);
                
                // Cargar opciones iniciales
                this.loadOptions();
            }

            bindEvents() {
                // Click en trigger
                this.trigger.addEventListener('click', (e) => {
                    e.stopPropagation();
                    this.toggle();
                });
                
                // Búsqueda
                if (this.searchInput) {
                    this.searchInput.addEventListener('input', (e) => {
                        this.handleSearch(e.target.value);
                    });
                    
                    this.searchInput.addEventListener('keydown', (e) => {
                        e.stopPropagation();
                    });
                }
                
                // Click fuera para cerrar
                document.addEventListener('click', (e) => {
                    if (!this.container.contains(e.target)) {
                        this.close();
                    }
                });
                
                // Teclado
                document.addEventListener('keydown', (e) => {
                    if (this.isOpen && e.key === 'Escape') {
                        this.close();
                    }
                });
            }

            loadOptions() {
                if (this.options.ajax) {
                    this.loadRemoteOptions();
                } else {
                    this.loadLocalOptions();
                }
            }

            loadLocalOptions() {
                this.filteredOptions = Array.from(this.element.options)
                    .filter(option => option.value !== '')
                    .map(option => ({
                        value: option.value,
                        text: option.textContent,
                        selected: option.selected,
                        disabled: option.disabled
                    }));
                
                // Cargar valores seleccionados iniciales
                this.selectedValues = this.filteredOptions
                    .filter(option => option.selected)
                    .map(option => option.value);
                
                this.renderOptions();
            }

            async loadRemoteOptions(query = '') {
                if (!this.options.ajax) return;
                
                if (query.length < this.options.minimumInputLength) {
                    this.filteredOptions = [];
                    this.renderOptions();
                    return;
                }
                
                try {
                    const results = await this.options.ajax(query);
                    this.filteredOptions = results.map(item => ({
                        value: item.id || item.value,
                        text: item.text || item.name,
                        selected: false,
                        disabled: false
                    }));
                    this.renderOptions();
                } catch (error) {
                    console.error('Error loading remote options:', error);
                }
            }

            renderOptions() {
                this.optionsContainer.innerHTML = '';
                
                if (this.filteredOptions.length === 0) {
                    const noResults = document.createElement('div');
                    noResults.className = 'custom-select-option no-results';
                    noResults.textContent = 'No se encontraron resultados';
                    this.optionsContainer.appendChild(noResults);
                    return;
                }
                
                this.filteredOptions.forEach((option, index) => {
                    const optionElement = document.createElement('div');
                    optionElement.className = 'custom-select-option';
                    optionElement.textContent = option.text;
                    
                    if (option.disabled) {
                        optionElement.classList.add('disabled');
                    }
                    
                    if (this.selectedValues.includes(option.value)) {
                        optionElement.classList.add('selected');
                    }
                    
                    if (!option.disabled) {
                        optionElement.addEventListener('click', () => {
                            this.selectOption(option);
                        });
                    }
                    
                    this.optionsContainer.appendChild(optionElement);
                });
            }

            selectOption(option) {
                if (this.options.multiple) {
                    if (this.selectedValues.includes(option.value)) {
                        this.selectedValues = this.selectedValues.filter(v => v !== option.value);
                    } else {
                        this.selectedValues.push(option.value);
                    }
                } else {
                    this.selectedValues = [option.value];
                    this.close();
                }
                
                this.updateOriginalSelect();
                this.updateDisplay();
                this.renderOptions();
                this.triggerChange();
            }

            removeTag(value) {
                this.selectedValues = this.selectedValues.filter(v => v !== value);
                this.updateOriginalSelect();
                this.updateDisplay();
                this.renderOptions();
                this.triggerChange();
            }

            updateOriginalSelect() {
                Array.from(this.element.options).forEach(option => {
                    option.selected = this.selectedValues.includes(option.value);
                });
            }

            updateDisplay() {
                const valueContainer = this.trigger.querySelector('.custom-select-value');
                
                if (this.selectedValues.length === 0) {
                    valueContainer.innerHTML = `<span class="custom-select-placeholder">${this.options.placeholder}</span>`;
                    return;
                }
                
                if (this.options.multiple) {
                    const tags = this.selectedValues.map(value => {
                        const option = this.filteredOptions.find(opt => opt.value === value) ||
                                     Array.from(this.element.options).find(opt => opt.value === value);
                        const text = option ? (option.text || option.textContent) : value;
                        
                        return `
                            <span class="select-tag">
                                ${text}
                                <span class="select-tag-remove" data-value="${value}">×</span>
                            </span>
                        `;
                    }).join('');
                    
                    valueContainer.innerHTML = tags;
                    
                    // Bind remove events
                    valueContainer.querySelectorAll('.select-tag-remove').forEach(remove => {
                        remove.addEventListener('click', (e) => {
                            e.stopPropagation();
                            this.removeTag(remove.dataset.value);
                        });
                    });
                } else {
                    const option = this.filteredOptions.find(opt => opt.value === this.selectedValues[0]) ||
                                  Array.from(this.element.options).find(opt => opt.value === this.selectedValues[0]);
                    const text = option ? (option.text || option.textContent) : this.selectedValues[0];
                    valueContainer.textContent = text;
                }
            }

            handleSearch(query) {
                if (this.options.ajax) {
                    this.loadRemoteOptions(query);
                } else {
                    const filtered = Array.from(this.element.options)
                        .filter(option => {
                            if (option.value === '') return false;
                            return option.textContent.toLowerCase().includes(query.toLowerCase());
                        })
                        .map(option => ({
                            value: option.value,
                            text: option.textContent,
                            selected: option.selected,
                            disabled: option.disabled
                        }));
                    
                    this.filteredOptions = filtered;
                    this.renderOptions();
                }
            }

            open() {
                if (this.isOpen) return;
                
                this.isOpen = true;
                this.trigger.classList.add('active');
                this.dropdown.classList.add('show');
                
                if (this.searchInput) {
                    this.searchInput.focus();
                    this.searchInput.value = '';
                    this.handleSearch('');
                }
            }

            close() {
                if (!this.isOpen) return;
                
                this.isOpen = false;
                this.trigger.classList.remove('active');
                this.dropdown.classList.remove('show');
            }

            toggle() {
                if (this.isOpen) {
                    this.close();
                } else {
                    this.open();
                }
            }

            triggerChange() {
                const event = new Event('change', { bubbles: true });
                this.element.dispatchEvent(event);
            }

            destroy() {
                this.container.remove();
                this.element.style.display = '';
            }

            // Métodos públicos para interactuar con el select
            getValue() {
                return this.options.multiple ? this.selectedValues : this.selectedValues[0] || null;
            }

            setValue(value) {
                if (this.options.multiple) {
                    this.selectedValues = Array.isArray(value) ? value : [value];
                } else {
                    this.selectedValues = value ? [value] : [];
                }
                this.updateOriginalSelect();
                this.updateDisplay();
                this.renderOptions();
            }

            clear() {
                this.selectedValues = [];
                this.updateOriginalSelect();
                this.updateDisplay();
                this.renderOptions();
                this.triggerChange();
            }
        }