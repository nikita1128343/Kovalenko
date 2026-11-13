#nullable disable

namespace RaceLog;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        lblDriver = new Label();
        txtDriver = new TextBox();
        lblCar = new Label();
        cmbCar = new ComboBox();
        lblTrack = new Label();
        cmbTrack = new ComboBox();
        lblTime = new Label();
        txtTime = new TextBox();
        btnAdd = new Button();
        btnClear = new Button();
        lblResults = new Label();
        lstResults = new ListBox();
        btnDelete = new Button();
        lblStatus = new Label();
        SuspendLayout();
        // 
        // lblDriver
        // 
        lblDriver.AutoSize = true;
        lblDriver.Location = new Point(24, 28);
        lblDriver.Name = "lblDriver";
        lblDriver.Size = new Size(58, 23);
        lblDriver.TabIndex = 8;
        lblDriver.Text = "Пилот";
        // 
        // txtDriver
        // 
        txtDriver.Location = new Point(24, 54);
        txtDriver.Name = "txtDriver";
        txtDriver.Size = new Size(250, 30);
        txtDriver.TabIndex = 0;
        // 
        // lblCar
        // 
        lblCar.AutoSize = true;
        lblCar.Location = new Point(24, 98);
        lblCar.Name = "lblCar";
        lblCar.Size = new Size(107, 23);
        lblCar.TabIndex = 9;
        lblCar.Text = "Автомобиль";
        // 
        // cmbCar
        // 
        cmbCar.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbCar.FormattingEnabled = true;
        cmbCar.Items.AddRange(new object[] { "Street", "Sport", "Prototype" });
        cmbCar.Location = new Point(24, 124);
        cmbCar.Name = "cmbCar";
        cmbCar.Size = new Size(250, 31);
        cmbCar.TabIndex = 1;
        // 
        // lblTrack
        // 
        lblTrack.AutoSize = true;
        lblTrack.Location = new Point(24, 168);
        lblTrack.Name = "lblTrack";
        lblTrack.Size = new Size(63, 23);
        lblTrack.TabIndex = 10;
        lblTrack.Text = "Трасса";
        // 
        // cmbTrack
        // 
        cmbTrack.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbTrack.FormattingEnabled = true;
        cmbTrack.Items.AddRange(new object[] { "Учебный овал", "Городское кольцо", "Спринт" });
        cmbTrack.Location = new Point(24, 194);
        cmbTrack.Name = "cmbTrack";
        cmbTrack.Size = new Size(250, 31);
        cmbTrack.TabIndex = 2;
        // 
        // lblTime
        // 
        lblTime.AutoSize = true;
        lblTime.Location = new Point(24, 238);
        lblTime.Name = "lblTime";
        lblTime.Size = new Size(124, 23);
        lblTime.TabIndex = 11;
        lblTime.Text = "Время круга, с";
        // 
        // txtTime
        // 
        txtTime.Location = new Point(24, 264);
        txtTime.Name = "txtTime";
        txtTime.Size = new Size(250, 30);
        txtTime.TabIndex = 3;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(24, 316);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(112, 34);
        btnAdd.TabIndex = 4;
        btnAdd.Text = "Добавить";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnClear
        // 
        btnClear.Location = new Point(146, 316);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(128, 34);
        btnClear.TabIndex = 5;
        btnClear.Text = "Очистить поля";
        btnClear.UseVisualStyleBackColor = true;
        btnClear.Click += btnClear_Click;
        // 
        // lblResults
        // 
        lblResults.AutoSize = true;
        lblResults.Location = new Point(304, 28);
        lblResults.Name = "lblResults";
        lblResults.Size = new Size(165, 23);
        lblResults.TabIndex = 12;
        lblResults.Text = "Результаты заездов";
        // 
        // lstResults
        // 
        lstResults.FormattingEnabled = true;
        lstResults.HorizontalScrollbar = true;
        lstResults.IntegralHeight = false;
        lstResults.ItemHeight = 23;
        lstResults.Location = new Point(304, 54);
        lstResults.Name = "lstResults";
        lstResults.Size = new Size(652, 296);
        lstResults.TabIndex = 6;
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(304, 370);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(204, 34);
        btnDelete.TabIndex = 7;
        btnDelete.Text = "Удалить выбранную";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // lblStatus
        // 
        lblStatus.Location = new Point(24, 434);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(932, 48);
        lblStatus.TabIndex = 13;
        lblStatus.Text = "Введите имя пилота";
        // 
        // Form1
        // 
        AcceptButton = btnAdd;
        AutoScaleDimensions = new SizeF(120F, 120F);
        AutoScaleMode = AutoScaleMode.Dpi;
        ClientSize = new Size(980, 500);
        Controls.Add(lblDriver);
        Controls.Add(txtDriver);
        Controls.Add(lblCar);
        Controls.Add(cmbCar);
        Controls.Add(lblTrack);
        Controls.Add(cmbTrack);
        Controls.Add(lblTime);
        Controls.Add(txtTime);
        Controls.Add(btnAdd);
        Controls.Add(btnClear);
        Controls.Add(lblResults);
        Controls.Add(lstResults);
        Controls.Add(btnDelete);
        Controls.Add(lblStatus);
        Font = new Font("Segoe UI", 10F);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Журнал заездов";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblDriver;
    private TextBox txtDriver;
    private Label lblCar;
    private ComboBox cmbCar;
    private Label lblTrack;
    private ComboBox cmbTrack;
    private Label lblTime;
    private TextBox txtTime;
    private Button btnAdd;
    private Button btnClear;
    private Label lblResults;
    private ListBox lstResults;
    private Button btnDelete;
    private Label lblStatus;
}
