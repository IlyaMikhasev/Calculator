using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    internal class Form_type
    {
       
            public static Region myRegion;
        static public void setOriginalButton(Button but, string _form = "стандарт")
        {

            System.Drawing.Drawing2D.GraphicsPath myPathButt = new System.Drawing.Drawing2D.GraphicsPath();
            if (_form == "восьмиграник")
            {
                but.BackColor = Color.IndianRed;
                myPathButt.AddPolygon(new Point[] { new Point(but.Size.Width/3, 0),
                                                new Point(but.Size.Width-but.Size.Width/3, 0),
                                                new Point(but.Size.Width, but.Size.Height/3),
                                                new Point(but.Size.Width, but.Size.Height-but.Size.Height/3),
                                                new Point(but.Size.Width-but.Size.Width/3, but.Size.Height),
                                                new Point(but.Size.Width/3, but.Size.Height),
                                                new Point(0, but.Size.Height-but.Size.Height/3),
                                                new Point(0, but.Size.Height/3) });
                myRegion = new Region(myPathButt);
                but.Region = myRegion;
            }
            else
                if (_form == "элипс")
            {
                but.BackColor = Color.Green;
                myPathButt.AddEllipse(3, 3, but.Width - 7, but.Height - 7);//3 и 7 магические числа, для корреции ввида                                               
                myRegion = new Region(myPathButt);
                but.Region = myRegion;

            }
            else
                if (_form == "трапеция")
            {
                Point[] myPoint = { new Point(3,5),
                                    new Point(but.Width-5, 5),
                                    new Point(but.Width-10, but.Height-5),
                                    new Point(8, but.Height-5)};// 3,5,8,10 - магические числа для визуализации
                myPathButt.AddPolygon(myPoint);
                myRegion = new Region(myPathButt);
                but.Region = myRegion;
                but.BackColor = Color.Blue;
            }
            else
            {
                but.BackColor= Button.DefaultBackColor;
                myPathButt.AddPolygon(new Point[] { new Point(0, 0),
                                                new Point(but.Size.Width, 0),
                                                new Point(but.Size.Width, but.Size.Height),
                                                new Point(0, but.Size.Height) });
                myRegion = new Region(myPathButt);
                but.Region = myRegion;
            }

        }
        static public void setOriginalForm(Form form, string _form = "стандарт")
        {
           
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            if (_form == "восьмиграник")
            {
                
                form.FormBorderStyle = FormBorderStyle.None;
                form.BackColor = Color.Orange;
               
                myPath.AddPolygon(new Point[] { new Point(form.Width/4, 0), 
                                                new Point(form.Width-form.Width/4, 0), 
                                                new Point(form.Width, form.Height/4),
                                                new Point(form.Width, form.Height-form.Height/4),
                                                new Point(form.Width-form.Width/4, form.Height),
                                                new Point(form.Width/4, form.Height),
                                                new Point(0, form.Height-form.Height/4),
                                                new Point(0, form.Height/4) }); 
                myRegion = new Region(myPath);
                form.Region = myRegion;
            }
            else
                if (_form == "элипс")
            {                
                
                form.FormBorderStyle = FormBorderStyle.None;
                form.BackColor = Color.LightGreen;             
                myPath.AddEllipse(0, 0, form.Width, form.Height);                                       
                myRegion = new Region(myPath);
                form.Region = myRegion;

            }
            else
                if (_form == "трапеция")
            {
                form.FormBorderStyle = FormBorderStyle.None;
                Point[] myPoint = { new Point(0,0),
                 new Point(form.Width, 0),
                 new Point(form.Width-50, form.Height),
                 new Point(50, form.Height)};
                myPath.AddPolygon(myPoint);
                myRegion = new Region(myPath);
                form.Region = myRegion;
                form.BackColor= Color.LightBlue;
            }
            else
            {
                form.FormBorderStyle = FormBorderStyle.FixedSingle;
                form.BackColor = Form.DefaultBackColor;
            }

        }
        
    }
}
