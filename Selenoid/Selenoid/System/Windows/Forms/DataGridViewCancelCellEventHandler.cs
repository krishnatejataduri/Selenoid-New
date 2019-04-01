namespace System.Windows.Forms
{
    internal class DataGridViewCancelCellEventHandler
    {
        private Action<object, DataGridViewCellEventArgs> dataGridView_Objects_CellClick;

        public DataGridViewCancelCellEventHandler(Action<object, DataGridViewCellEventArgs> dataGridView_Objects_CellClick)
        {
            this.dataGridView_Objects_CellClick = dataGridView_Objects_CellClick;
        }
    }
}