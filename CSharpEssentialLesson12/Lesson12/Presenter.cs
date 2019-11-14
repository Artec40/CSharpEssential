using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    class Presenter
    {
        Model model;
        MainWindow mainWindow;

        public Presenter(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            this.model = new Model();
            this.mainWindow.AddEvent += mainWindow_AddEvent;
            this.mainWindow.SubEvent += mainWindow_SubEvent;
            this.mainWindow.MulEvent += mainWindow_MulEvent;
            this.mainWindow.DivEvent += mainWindow_DivEvent;
        }

        void mainWindow_AddEvent(object sender, EventArgs e)
        {
            this.mainWindow.Result.Text = this.model.Plus(Convert.ToInt32(mainWindow.FirstUserValue.Text), Convert.ToInt32(mainWindow.SecondUserValue.Text));
        }

        void mainWindow_SubEvent(object sender, EventArgs e)
        {
            this.mainWindow.Result.Text = this.model.Sub(Convert.ToInt32(mainWindow.FirstUserValue.Text), Convert.ToInt32(mainWindow.SecondUserValue.Text));
        }

        void mainWindow_MulEvent(object sender, EventArgs e)
        {
            this.mainWindow.Result.Text = this.model.Mul(Convert.ToInt32(mainWindow.FirstUserValue.Text), Convert.ToInt32(mainWindow.SecondUserValue.Text));
        }

        void mainWindow_DivEvent(object sender, EventArgs e)
        {
            this.mainWindow.Result.Text = this.model.Div(Convert.ToInt32(mainWindow.FirstUserValue.Text), Convert.ToInt32(mainWindow.SecondUserValue.Text));
        }
    }
}
