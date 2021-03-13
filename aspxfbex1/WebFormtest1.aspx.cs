using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspxfbex1
{
    public partial class WebFormtest1 : System.Web.UI.Page
    {
       
        private void Page_Load(object sender, EventArgs e)
        {



            //TextBox1.Text = "fangbing时间:                " + DateTime.Now.ToString();
            //TextBox1.ReadOnly = true;  //设置为只读
            //System.Timers.Timer t = new System.Timers.Timer(1000);
            //t.Elapsed += new System.Timers.ElapsedEventHandler(refreshTime);
            //t.AutoReset = true;//设置是执行一次（false）还是一直执行(true)；
            //t.Enabled = true;//是否执行System.Timers.Timer.Elapsed事件；
            //t.Start();
            //timer1_Tick(object sender, EventArgs e);



        }
        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    DateTime dt = System.DateTime.Now;
        //    TextBox1.Text = dt.ToString();
        //}
        protected void Btnclk(object sender, EventArgs e)
        {
            TextBox1.Text = "fangbing时间:                " + DateTime.Now.ToString();
           


        }
        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //    //实例化timer，使得间隔为1000ms

        //}

        //对事件的描述
        //public void refreshTime(object source, System.Timers.ElapsedEventArgs e)
        //{
        //    TextBox1.Text = "fangbing时间:                " + DateTime.Now.ToString();
        //}

    }
}