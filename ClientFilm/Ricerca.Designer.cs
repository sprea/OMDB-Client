namespace ClientFilm
{
    partial class Ricerca
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ricerca));
            this.SearchBox = new System.Windows.Forms.GroupBox();
            this.options_box = new System.Windows.Forms.GroupBox();
            this.YearFilter_checkbox = new System.Windows.Forms.CheckBox();
            this.TypeFilter_checkbox = new System.Windows.Forms.CheckBox();
            this.DeleteItems_button = new System.Windows.Forms.Button();
            this.Year_filter_box = new System.Windows.Forms.GroupBox();
            this.AnnoBox = new System.Windows.Forms.ComboBox();
            this.Type_filter_box = new System.Windows.Forms.GroupBox();
            this.serieradio = new System.Windows.Forms.RadioButton();
            this.filmradio = new System.Windows.Forms.RadioButton();
            this.TitleSearch_box = new System.Windows.Forms.GroupBox();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.Results_box = new System.Windows.Forms.GroupBox();
            this.Film_Table = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnnoFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExportCsv_button = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SearchBox.SuspendLayout();
            this.options_box.SuspendLayout();
            this.Year_filter_box.SuspendLayout();
            this.Type_filter_box.SuspendLayout();
            this.TitleSearch_box.SuspendLayout();
            this.Results_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Film_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.Controls.Add(this.options_box);
            this.SearchBox.Controls.Add(this.Year_filter_box);
            this.SearchBox.Controls.Add(this.Type_filter_box);
            this.SearchBox.Controls.Add(this.TitleSearch_box);
            this.SearchBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(12, 12);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(835, 216);
            this.SearchBox.TabIndex = 0;
            this.SearchBox.TabStop = false;
            this.SearchBox.Text = "Cerca";
            // 
            // options_box
            // 
            this.options_box.Controls.Add(this.ExportCsv_button);
            this.options_box.Controls.Add(this.YearFilter_checkbox);
            this.options_box.Controls.Add(this.TypeFilter_checkbox);
            this.options_box.Controls.Add(this.DeleteItems_button);
            this.options_box.Location = new System.Drawing.Point(557, 25);
            this.options_box.Name = "options_box";
            this.options_box.Size = new System.Drawing.Size(272, 185);
            this.options_box.TabIndex = 7;
            this.options_box.TabStop = false;
            this.options_box.Text = "Opzioni";
            // 
            // YearFilter_checkbox
            // 
            this.YearFilter_checkbox.AutoSize = true;
            this.YearFilter_checkbox.Location = new System.Drawing.Point(6, 140);
            this.YearFilter_checkbox.Name = "YearFilter_checkbox";
            this.YearFilter_checkbox.Size = new System.Drawing.Size(163, 23);
            this.YearFilter_checkbox.TabIndex = 5;
            this.YearFilter_checkbox.Text = "Filtra per anno";
            this.YearFilter_checkbox.UseVisualStyleBackColor = true;
            this.YearFilter_checkbox.CheckedChanged += new System.EventHandler(this.YearFilter_checkbox_CheckedChanged);
            // 
            // TypeFilter_checkbox
            // 
            this.TypeFilter_checkbox.AutoSize = true;
            this.TypeFilter_checkbox.Location = new System.Drawing.Point(6, 111);
            this.TypeFilter_checkbox.Name = "TypeFilter_checkbox";
            this.TypeFilter_checkbox.Size = new System.Drawing.Size(208, 23);
            this.TypeFilter_checkbox.TabIndex = 4;
            this.TypeFilter_checkbox.Text = "Filtra per tipologia";
            this.TypeFilter_checkbox.UseVisualStyleBackColor = true;
            this.TypeFilter_checkbox.CheckedChanged += new System.EventHandler(this.TypeFilter_checkbox_CheckedChanged);
            // 
            // DeleteItems_button
            // 
            this.DeleteItems_button.Location = new System.Drawing.Point(6, 25);
            this.DeleteItems_button.Name = "DeleteItems_button";
            this.DeleteItems_button.Size = new System.Drawing.Size(260, 38);
            this.DeleteItems_button.TabIndex = 3;
            this.DeleteItems_button.Text = "Cancella Elenco";
            this.DeleteItems_button.UseVisualStyleBackColor = true;
            this.DeleteItems_button.Click += new System.EventHandler(this.DeleteItems_button_Click);
            // 
            // Year_filter_box
            // 
            this.Year_filter_box.Controls.Add(this.AnnoBox);
            this.Year_filter_box.Enabled = false;
            this.Year_filter_box.Location = new System.Drawing.Point(159, 94);
            this.Year_filter_box.Name = "Year_filter_box";
            this.Year_filter_box.Size = new System.Drawing.Size(141, 116);
            this.Year_filter_box.TabIndex = 6;
            this.Year_filter_box.TabStop = false;
            this.Year_filter_box.Text = "Anno";
            // 
            // AnnoBox
            // 
            this.AnnoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnnoBox.FormattingEnabled = true;
            this.AnnoBox.Location = new System.Drawing.Point(6, 25);
            this.AnnoBox.MaxLength = 4;
            this.AnnoBox.Name = "AnnoBox";
            this.AnnoBox.Size = new System.Drawing.Size(126, 27);
            this.AnnoBox.TabIndex = 0;
            // 
            // Type_filter_box
            // 
            this.Type_filter_box.Controls.Add(this.serieradio);
            this.Type_filter_box.Controls.Add(this.filmradio);
            this.Type_filter_box.Enabled = false;
            this.Type_filter_box.Location = new System.Drawing.Point(6, 94);
            this.Type_filter_box.Name = "Type_filter_box";
            this.Type_filter_box.Size = new System.Drawing.Size(134, 116);
            this.Type_filter_box.TabIndex = 5;
            this.Type_filter_box.TabStop = false;
            this.Type_filter_box.Text = "Tipologia";
            // 
            // serieradio
            // 
            this.serieradio.AutoSize = true;
            this.serieradio.Location = new System.Drawing.Point(9, 83);
            this.serieradio.Name = "serieradio";
            this.serieradio.Size = new System.Drawing.Size(99, 23);
            this.serieradio.TabIndex = 1;
            this.serieradio.Text = "Serie Tv";
            this.serieradio.UseVisualStyleBackColor = true;
            // 
            // filmradio
            // 
            this.filmradio.AutoSize = true;
            this.filmradio.Checked = true;
            this.filmradio.Location = new System.Drawing.Point(9, 25);
            this.filmradio.Name = "filmradio";
            this.filmradio.Size = new System.Drawing.Size(63, 23);
            this.filmradio.TabIndex = 0;
            this.filmradio.TabStop = true;
            this.filmradio.Text = "Film";
            this.filmradio.UseVisualStyleBackColor = true;
            // 
            // TitleSearch_box
            // 
            this.TitleSearch_box.Controls.Add(this.search_textbox);
            this.TitleSearch_box.Controls.Add(this.search_btn);
            this.TitleSearch_box.Location = new System.Drawing.Point(6, 25);
            this.TitleSearch_box.Name = "TitleSearch_box";
            this.TitleSearch_box.Size = new System.Drawing.Size(545, 63);
            this.TitleSearch_box.TabIndex = 4;
            this.TitleSearch_box.TabStop = false;
            this.TitleSearch_box.Text = "Titolo";
            // 
            // search_textbox
            // 
            this.search_textbox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_textbox.Location = new System.Drawing.Point(6, 25);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(427, 26);
            this.search_textbox.TabIndex = 0;
            this.search_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.search_textbox_KeyPress);
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(439, 24);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(100, 27);
            this.search_btn.TabIndex = 1;
            this.search_btn.Text = "Ricerca";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Results_box
            // 
            this.Results_box.Controls.Add(this.Film_Table);
            this.Results_box.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Results_box.Location = new System.Drawing.Point(12, 234);
            this.Results_box.Name = "Results_box";
            this.Results_box.Size = new System.Drawing.Size(835, 496);
            this.Results_box.TabIndex = 2;
            this.Results_box.TabStop = false;
            this.Results_box.Text = "Risultati";
            // 
            // Film_Table
            // 
            this.Film_Table.AllowUserToAddRows = false;
            this.Film_Table.AllowUserToDeleteRows = false;
            this.Film_Table.AllowUserToResizeColumns = false;
            this.Film_Table.AllowUserToResizeRows = false;
            this.Film_Table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Film_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Film_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.NomeFilm,
            this.AnnoFilm,
            this.TipoFilm});
            this.Film_Table.Location = new System.Drawing.Point(21, 25);
            this.Film_Table.Name = "Film_Table";
            this.Film_Table.ReadOnly = true;
            this.Film_Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Film_Table.Size = new System.Drawing.Size(796, 463);
            this.Film_Table.TabIndex = 0;
            this.Film_Table.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Film_Table_CellDoubleClick);
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.MinimumWidth = 100;
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // NomeFilm
            // 
            this.NomeFilm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NomeFilm.HeaderText = "Nome";
            this.NomeFilm.MinimumWidth = 400;
            this.NomeFilm.Name = "NomeFilm";
            this.NomeFilm.ReadOnly = true;
            this.NomeFilm.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NomeFilm.Width = 400;
            // 
            // AnnoFilm
            // 
            this.AnnoFilm.HeaderText = "Anno";
            this.AnnoFilm.MinimumWidth = 100;
            this.AnnoFilm.Name = "AnnoFilm";
            this.AnnoFilm.ReadOnly = true;
            this.AnnoFilm.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TipoFilm
            // 
            this.TipoFilm.HeaderText = "Tipologia";
            this.TipoFilm.MinimumWidth = 200;
            this.TipoFilm.Name = "TipoFilm";
            this.TipoFilm.ReadOnly = true;
            this.TipoFilm.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TipoFilm.Width = 200;
            // 
            // ExportCsv_button
            // 
            this.ExportCsv_button.Location = new System.Drawing.Point(6, 67);
            this.ExportCsv_button.Name = "ExportCsv_button";
            this.ExportCsv_button.Size = new System.Drawing.Size(260, 38);
            this.ExportCsv_button.TabIndex = 6;
            this.ExportCsv_button.Text = "Esporta CSV";
            this.ExportCsv_button.UseVisualStyleBackColor = true;
            this.ExportCsv_button.Click += new System.EventHandler(this.ExportCsv_button_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "File CSV|.csv";
            this.saveFileDialog1.Title = "Esporta CSV";
            // 
            // Ricerca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 743);
            this.Controls.Add(this.Results_box);
            this.Controls.Add(this.SearchBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(873, 781);
            this.MinimumSize = new System.Drawing.Size(873, 781);
            this.Name = "Ricerca";
            this.Text = "Ricerca";
            this.SearchBox.ResumeLayout(false);
            this.options_box.ResumeLayout(false);
            this.options_box.PerformLayout();
            this.Year_filter_box.ResumeLayout(false);
            this.Type_filter_box.ResumeLayout(false);
            this.Type_filter_box.PerformLayout();
            this.TitleSearch_box.ResumeLayout(false);
            this.TitleSearch_box.PerformLayout();
            this.Results_box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Film_Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SearchBox;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.GroupBox Results_box;
        private System.Windows.Forms.DataGridView Film_Table;
        private System.Windows.Forms.Button DeleteItems_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnnoFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoFilm;
        private System.Windows.Forms.GroupBox Type_filter_box;
        private System.Windows.Forms.RadioButton serieradio;
        private System.Windows.Forms.RadioButton filmradio;
        private System.Windows.Forms.GroupBox TitleSearch_box;
        private System.Windows.Forms.GroupBox options_box;
        private System.Windows.Forms.CheckBox TypeFilter_checkbox;
        private System.Windows.Forms.GroupBox Year_filter_box;
        private System.Windows.Forms.ComboBox AnnoBox;
        private System.Windows.Forms.CheckBox YearFilter_checkbox;
        private System.Windows.Forms.Button ExportCsv_button;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

