// ...existing code...

private DateTimePicker _dateTimePicker;

private void InitializeDateTimePicker()
{
    _dateTimePicker = new DateTimePicker
    {
        Format = DateTimePickerFormat.Short,
        Visible = false
    };
    _dateTimePicker.ValueChanged += DateTimePicker_ValueChanged;
    this.Controls.Add(_dateTimePicker);
}

private void dgvTodos_CellClick(object sender, DataGridViewCellEventArgs e)
{
    if (e.RowIndex >= 0 && (dgvTodos.Columns[e.ColumnIndex].Name == "DateToBeCompleted" || dgvTodos.Columns[e.ColumnIndex].Name == "DateAdded"))
    {
        Rectangle cellRectangle = dgvTodos.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
        _dateTimePicker.Location = new Point(cellRectangle.X + dgvTodos.Location.X, cellRectangle.Y + dgvTodos.Location.Y);
        _dateTimePicker.Size = cellRectangle.Size;

        if (DateTime.TryParse(dgvTodos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString(), out DateTime cellValue))
        {
            _dateTimePicker.Value = cellValue;
        }
        else
        {
            _dateTimePicker.Value = DateTime.Now;
        }

        _dateTimePicker.Visible = true;
        _dateTimePicker.Tag = new { RowIndex = e.RowIndex, ColumnIndex = e.ColumnIndex };
    }
    else
    {
        _dateTimePicker.Visible = false;
    }
}

private void DateTimePicker_ValueChanged(object sender, EventArgs e)
{
    if (_dateTimePicker.Tag is { RowIndex: int rowIndex, ColumnIndex: int columnIndex })
    {
        dgvTodos.Rows[rowIndex].Cells[columnIndex].Value = _dateTimePicker.Value;
        _dateTimePicker.Visible = false;
    }
}

private void dgvTodos_DataError(object sender, DataGridViewDataErrorEventArgs e)
{
    // Silently fail and visually mark the row with an error
    if (e.RowIndex >= 0)
    {
        dgvTodos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral; // Highlight row in light red
        dgvTodos.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White; // Ensure text is readable
    }

    e.ThrowException = false; // Prevent the default error dialog
}

public async void LoadTodos()
{
    try
    {
        List<ToDo> todos = await _todosManager.GetAllAsync();

        // Ensure valid DateTime values for 'Complete By' and 'Date Added' columns
        foreach (var todo in todos)
        {
            if (todo.DateToBeCompleted == DateTime.MinValue)
            {
                todo.DateToBeCompleted = DateTime.Now; // Default to current date if invalid
            }

            if (todo.DateAdded == DateTime.MinValue)
            {
                todo.DateAdded = DateTime.Now; // Default to current date if invalid
            }
        }

        BindingSource bindingSource = new BindingSource();
        bindingSource.DataSource = todos;
        dgvTodos.DataSource = bindingSource;

        dgvTodos.Refresh();
    }
    catch (Exception ex)
    {
        MessageBox.Show($"An error occurred: {ex.Message}",
            "Couldn't load todos.",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
        return;
    }
}

// ...existing code...

private void ApplyModernUI()
{
    // ...existing code...

    // Attach the DataError event to the DataGridView
    dgvTodos.DataError += dgvTodos_DataError;

    // Initialize the DateTimePicker
    InitializeDateTimePicker();

    // Attach the CellClick event to the DataGridView
    dgvTodos.CellClick += dgvTodos_CellClick;

    // ...existing code...
}
