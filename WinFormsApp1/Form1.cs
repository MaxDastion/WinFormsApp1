namespace WinFormsApp1
{ 
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private void AddCellSn()
        {


            Panel item = new Panel();
            item.BackColor = Color.Lime;
            item.Dock = DockStyle.Fill;
            item.Location = new Point(381, 81);
            item.Name = "panel1";



























            item.Size = new Size(21, 20);
            item.TabIndex = 0;
            Snake.Add(item);
            if (_TempArrow == _MoveArrow.Up)
                tableLayoutPanel1.Controls.Add(item, tableLayoutPanel1.GetColumn(this.item), tableLayoutPanel1.GetRow(this.item) + 1);
            else if (_TempArrow == _MoveArrow.Down)
                tableLayoutPanel1.Controls.Add(item, tableLayoutPanel1.GetColumn(this.item), tableLayoutPanel1.GetRow(this.item) - 1);
            else if (_TempArrow == _MoveArrow.Left)
                tableLayoutPanel1.Controls.Add(item, tableLayoutPanel1.GetColumn(this.item) + 1, tableLayoutPanel1.GetRow(this.item));
            else if (_TempArrow == _MoveArrow.Right)
                tableLayoutPanel1.Controls.Add(item, tableLayoutPanel1.GetColumn(this.item) - 1, tableLayoutPanel1.GetRow(this.item));

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void MoveSnArr_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {

                case Keys.A:
                    if (_TempArrow != _MoveArrow.Right)
                    _TempArrow = _MoveArrow.Left;
                    break;

                case Keys.D:

                    if (_TempArrow != _MoveArrow.Left)
                        _TempArrow = _MoveArrow.Right;
                    break;

                case Keys.S:

                    if (_TempArrow != _MoveArrow.Up)
                        _TempArrow = _MoveArrow.Down;
                    break;

                case Keys.W:

                    if (_TempArrow != _MoveArrow.Down)
                        _TempArrow = _MoveArrow.Up;
                    break;
                    case Keys.X:
                    AddCellSn();
                    break;

            }
        }

        private void TickMoveSn(object sender, EventArgs e)
        {

            foreach (Control item in tableLayoutPanel1.Controls)
            {


                switch (_TempArrow)
                {
                    
                    case _MoveArrow.Left:
                        if (tableLayoutPanel1.GetColumn(item) - 1 > -1 )

                            tableLayoutPanel1.SetColumn(item, tableLayoutPanel1.GetColumn(item) - 1);

                        break;
                    case _MoveArrow.Right:
                        if (tableLayoutPanel1.GetColumn(item) + 1 < tableLayoutPanel1.ColumnCount)

                            tableLayoutPanel1.SetColumn(item, tableLayoutPanel1.GetColumn(item) + 1);

                        break;
                    case _MoveArrow.Up:
                        if (tableLayoutPanel1.GetRow(item) - 1 > -1)

                            tableLayoutPanel1.SetRow(item, tableLayoutPanel1.GetRow(item) - 1);
                        break;
                    case _MoveArrow.Down:
                        if (tableLayoutPanel1.GetRow(item) + 1 < tableLayoutPanel1.RowCount)

                            tableLayoutPanel1.SetRow(item, tableLayoutPanel1.GetRow(item) + 1);
                        break;
                    default:
                        break;

                        Thread.Sleep(100);
                }
            }
            
        }
    }
}
