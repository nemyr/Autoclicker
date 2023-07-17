using System.Windows.Input;
namespace Autoclicker
{
    public partial class Form1 : Form
    {

        private int _delay = 50;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("eee");
            this.lbDelay.Text = _delay.ToString();
            Cursor.Position = new Point(1, 1);
            //MouseDown(sender, )
        }

        class A
        {
            public int x { get; set; }
            public List<int> list { get; set; }
            public A(int a) { 
                list = new List<int>() { 1,2,3 };
                x = a;
            }
        };

        class B { 

            public A a { get; set; }

            public B(A a)
            {
                this.a = a;
            }

            public void pr(int p1, int p2)
            {
                a.x = p1;
                a.list.Add(p2);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var a = new A(5);
            var b = new B(a);
            b.pr(1, _delay);

            _delay++;
            button1.Text = _delay.ToString();
            this.Text = ($"x={a.x}/{b.a.x} a.l={a.list.Last()}/{b.a.list.Last()}");
        }
    }
}