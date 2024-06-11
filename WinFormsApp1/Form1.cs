using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private TableLayoutPanelCellPosition _lastSegmentPosition;

        public Form1()
        {
            InitializeComponent();
            InitializeSnake();
        }
        private void AddCellSn()
        {
            int col = tableLayoutPanel1.GetColumn(Snake.SnakeBody[Snake.SnakeBody.Count - 1].Key);
            int row = tableLayoutPanel1.GetRow(Snake.SnakeBody[Snake.SnakeBody.Count - 1].Key);


            Panel item = new Panel();
            item.BackColor = Color.Lime;
            item.Dock = DockStyle.Fill;
            item.Location = new Point(381, 81);
            item.Name = "panel1";


            item.Size = new Size(21, 20);
            item.TabIndex = 0;

            Snake.Add(item, Status.BODY);
            switch (_TempArrow)
            {
                case _MoveArrow.Left:
                    col += 1;
                    break;
                case _MoveArrow.Right:
                    col -= 1;
                    break;
                case _MoveArrow.Up:
                    row += 1;
                    break;
                case _MoveArrow.Down:
                    row -= 1;
                    break;
            }
            tableLayoutPanel1.Controls.Add(item, col, row);
        }
        private void InitializeSnake()
        {
            // Создание начальной змеи
            AddCellSn(3, 3, Status.HEAD); // Голова
            AddCellSn(2, 3, Status.BODY); // Тело
            AddCellSn(1, 3, Status.TAIL); // Хвост
        }

        private void AddCellSn(int col, int row, Status status)
        {
            Panel item = new Panel();
            item.BackColor = Color.Lime;
            item.Size = new Size(21, 20);
            item.TabIndex = 0;
            Snake.Add(item, status);
            tableLayoutPanel1.Controls.Add(item, col, row);
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

            for (int i = Snake.SnakeBody.Count - 1; i >= 0; i--)
            {
                var segment = Snake.SnakeBody[i].Key;
                int col = tableLayoutPanel1.GetColumn(segment);
                int row = tableLayoutPanel1.GetRow(segment);

                if (i == 0)
                { 
                   
                    _lastSegmentPosition = new TableLayoutPanelCellPosition(col, row);
                }

                if (i > 0)
                {
                    var previousSegment = Snake.SnakeBody[i - 1].Key;
                    tableLayoutPanel1.SetCellPosition(segment, tableLayoutPanel1.GetCellPosition(previousSegment));
                }
                else 
                {
                    switch (_TempArrow)
                    {
                        case _MoveArrow.Left:
                            col--;
                            break;
                        case _MoveArrow.Right:
                            col++;
                            break;
                        case _MoveArrow.Up:
                            row--;
                            break;
                        case _MoveArrow.Down:
                            row++;
                            break;
                    }

                    tableLayoutPanel1.SetCellPosition(segment, new TableLayoutPanelCellPosition(col, row));
                }
            }
        }
    }
}
