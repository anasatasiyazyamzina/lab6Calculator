using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Calculator
{
    /// <summary>  
    /// Основной класс калькулятора  
    /// </summary>  
    /// <param name="___OriginalRect">основные координаты</param>  
    public partial class Calculate : Form
    {
        private Rectangle textBox1OriginalRect;
        private Rectangle textBox2OriginalRect;
        private Rectangle number0OriginalRect;
        private Rectangle number1OriginalRect;
        private Rectangle number2OriginalRect;
        private Rectangle number3OriginalRect;
        private Rectangle number4OriginalRect;
        private Rectangle number5OriginalRect;
        private Rectangle number6OriginalRect;
        private Rectangle number7OriginalRect;
        private Rectangle number8OriginalRect;
        private Rectangle number9OriginalRect;
        private Rectangle CEOriginalRect;
        private Rectangle comaOriginalRect;
        private Rectangle bminOriginalRect;
        private Rectangle bplOriginalRect;
        private Rectangle bmulOriginalRect;
        private Rectangle bdivOriginalRect;
        private Rectangle inevOriginalRect;

        /// <param name="formOriginalSize">Основные прааметры размера формы</param>  
        private Size formOriginalSize;

        /// <summary>  
        /// Инициализация калькулятора
        /// </summary>  
        public Calculate()
        {
            InitializeComponent();

        }
        #region Автоматическое измение формы в зависимости от размера окна
        /// <summary>  
        /// Основной загрузчик формы калькулятора  
        /// </summary>
        /// <param name="____OriginalRect">Координаты кнопок</param>
        void Calculate_Load(object sender, EventArgs e)
        {
            formOriginalSize = this.Size;
            textBox1OriginalRect = new Rectangle(textBox1.Location.X, textBox1.Location.Y, textBox1.Width, textBox1.Height);
            textBox2OriginalRect = new Rectangle(textBox2.Location.X, textBox2.Location.Y, textBox2.Width, textBox2.Height);
            number0OriginalRect = new Rectangle(number0.Location.X, number0.Location.Y, number0.Width, number0.Height);
            number1OriginalRect = new Rectangle(number1.Location.X, number1.Location.Y, number1.Width, number1.Height);
            number2OriginalRect = new Rectangle(number2.Location.X, number2.Location.Y, number2.Width, number2.Height);
            number3OriginalRect = new Rectangle(number3.Location.X, number3.Location.Y, number3.Width, number3.Height);
            number4OriginalRect = new Rectangle(number4.Location.X, number4.Location.Y, number4.Width, number4.Height);
            number5OriginalRect = new Rectangle(number5.Location.X, number5.Location.Y, number5.Width, number5.Height);
            number6OriginalRect = new Rectangle(number6.Location.X, number6.Location.Y, number6.Width, number6.Height);
            number7OriginalRect = new Rectangle(number7.Location.X, number7.Location.Y, number7.Width, number7.Height);
            number8OriginalRect = new Rectangle(number8.Location.X, number8.Location.Y, number8.Width, number8.Height);
            number9OriginalRect = new Rectangle(number9.Location.X, number9.Location.Y, number9.Width, number9.Height);
            CEOriginalRect = new Rectangle(CE.Location.X, CE.Location.Y,CE.Width, CE.Height);
            comaOriginalRect = new Rectangle(coma.Location.X, coma.Location.Y, coma.Width, coma.Height);
            inevOriginalRect = new Rectangle(inevitably.Location.X, inevitably.Location.Y, inevitably.Width, inevitably.Height);
            bminOriginalRect = new Rectangle(bminus.Location.X, bminus.Location.Y, bminus.Width, bminus.Height);
            bplOriginalRect = new Rectangle(bplus.Location.X, bplus.Location.Y, bplus.Width, bplus.Height);
            bmulOriginalRect = new Rectangle(bmulti.Location.X, bmulti.Location.Y, bmulti.Width, bmulti.Height);
            bdivOriginalRect = new Rectangle(bdevide.Location.X, bdevide.Location.Y, bdevide.Width, bdevide.Height);
        }

        /// <summary>  
        /// Класс, контролирующий изменение размера кнопок и текстового поля в зависимоти от изменения размера формы 
        /// </summary>  
        private void resizeControl(Rectangle originalControlRect, Control control)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);

            int newX = (int)(originalControlRect.X * xRatio);
            int newY = (int)(originalControlRect.Y * yRatio);
            int newWidth = (int)(originalControlRect.Width * xRatio);
            int newHeigth = (int)(originalControlRect.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeigth);
        }

        private void resizeChildrenControls()
        {
            resizeControl(textBox1OriginalRect, textBox1);
            resizeControl(textBox2OriginalRect, textBox2);
            resizeControl(number0OriginalRect, number0);
            resizeControl(number1OriginalRect, number1);
            resizeControl(number2OriginalRect, number2);
            resizeControl(number3OriginalRect, number3);
            resizeControl(number4OriginalRect, number4);
            resizeControl(number5OriginalRect, number5);
            resizeControl(number6OriginalRect, number6);
            resizeControl(number7OriginalRect, number7);
            resizeControl(number8OriginalRect, number8);
            resizeControl(number9OriginalRect, number9);
            resizeControl(CEOriginalRect, CE);
            resizeControl(inevOriginalRect, inevitably);
            resizeControl(bminOriginalRect, bminus);
            resizeControl(bplOriginalRect, bplus);
            resizeControl(bmulOriginalRect, bmulti);
            resizeControl(bdivOriginalRect, bdevide);
            resizeControl(comaOriginalRect, coma);
        }

        private void Calculate_Resize(object sender, EventArgs e)
        {
            resizeChildrenControls();
        }
        #endregion

        private float a, b;
        int count;

        #region Обработчик кнопок формы
        private void number0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void number8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void number4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void number5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void number6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void number3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void number2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void number1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }
        private void number7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void number9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void CE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void coma_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void bminus_Click(object sender, EventArgs e)
        {
            try { a = float.Parse(textBox1.Text); } catch (Exception ex) { textBox2.Text = "Not valid"; }
            textBox1.Clear();
            count = 2;
            textBox2.Text = a.ToString() + "-";
        }


        private void bmulti_Click(object sender, EventArgs e)
        {
            try { a = float.Parse(textBox1.Text); } catch (Exception ex) { textBox2.Text = "Not valid"; }
            textBox1.Clear();
            count = 3;
            textBox2.Text = a.ToString() + "*";
        }

        private void bdevide_Click(object sender, EventArgs e)
        {
            try { a = float.Parse(textBox1.Text); } catch (Exception ex) { textBox2.Text = "Not valid"; }
            textBox1.Clear();
            count = 4;
            textBox2.Text = a.ToString() + "/";
        }

        private void inevitably_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void bplus_Click(object sender, EventArgs e)
        {
            try { a = float.Parse(textBox1.Text); } catch (Exception ex) { textBox2.Text = "Not valid"; }
            textBox1.Clear();
            count = 1;
            textBox2.Text = a.ToString() + "+";
        }
        #endregion

        #region Калькулятор
        private void calculate()
        {
            try { b = float.Parse(textBox1.Text);
            textBox2.Text = textBox2.Text + b + "=";
            }
            catch (System.FormatException e)
            {
                textBox2.Text = e.ToString();
            }

            switch (count)
            {
                case 1:
                    b = a + b;
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - b;
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * b;
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    if (b != 0)
                    {
                        b = a / b;
                        textBox1.Text = b.ToString();
                    }
                    else
                    {

                        textBox1.Text = b.ToString("на 0 не делим!");
                    }
                    break;
                default:
                        textBox1.Text = "";
                    textBox2.Text = "";
                   a = 0;
                    b = 0;
                        break;


            }
            count = 5;
        }
        #endregion
        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();
        }

     
        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();
        }


        #region KeyBoard Events  
        /// <summary>  
        /// Вызов метода обработчика клавиатурных кнопок при нажатии любой из требуемых кнопок формы  
        /// </summary>  
        /// <param name="sender"></param>  
        /// <param name="e"></param>  

        private void inevitably_KeyDown(object sender, KeyEventArgs e)
        {
           // MessageBox.Show(e.KeyValue.ToString());
            filterKeys(e.KeyValue);
        }

        private void bplus_KeyDown(object sender, KeyEventArgs e)
        {
            filterKeys(e.KeyValue);
        }

        private void bminus_KeyDown(object sender, KeyEventArgs e)
        {
            filterKeys(e.KeyValue);
        }

        private void bmulti_KeyDown(object sender, KeyEventArgs e)
        {
            filterKeys(e.KeyValue);
        }

        private void bdevide_KeyDown(object sender, KeyEventArgs e)
        {
            filterKeys(e.KeyValue);
        }

        private void coma_KeyDown(object sender, KeyEventArgs e)
        {
            filterKeys(e.KeyValue);
        }

        private void CE_KeyDown(object sender, KeyEventArgs e)
        {
            filterKeys(e.KeyValue);
        }


        /// <summary>  
        /// Метод, позволяющий обрабатывать клавиши 
        /// </summary>  
        /// <param name="keyCode">Код нажатой на клавиатуре кнопки</param>  
        public void filterKeys(int keyCode)
        {
            switch (keyCode)
            {
                case 48:
                    textBox1.AppendText("0");
                    break;
                case 49:
                    textBox1.AppendText("1");
                    break;
                case 50:
                    textBox1.AppendText("2");
                    break;
                case 51:
                    textBox1.AppendText("3");
                    break;
                case 52:
                    textBox1.AppendText("4");
                    break;
                case 53:
                    textBox1.AppendText("5");
                    break;
                case 54:
                    textBox1.AppendText("6");
                    break;
                case 55:
                    textBox1.AppendText("7");
                    break;
                case 56:
                    textBox1.AppendText("8");
                    break;
                case 57:
                    textBox1.AppendText("9");
                    break;
                case 96:
                    textBox1.AppendText("0");
                    break;
                case 97:
                     textBox1.AppendText("1");
                    break;
                case 98:
                     textBox1.AppendText("2");
                    break;
                case 99:
                     textBox1.AppendText("3");
                    break;
                case 100:
                     textBox1.AppendText("4");
                    break;
                case 101:
                     textBox1.AppendText("5");
                    break;
                case 102:
                     textBox1.AppendText("6");
                    break;
                case 103:
                     textBox1.AppendText("7");
                    break;
                case 104:
                     textBox1.AppendText("8");
                    break;
                case 105:
                     textBox1.AppendText("9");
                    break;
            }
        }
        #endregion 
    }
}

