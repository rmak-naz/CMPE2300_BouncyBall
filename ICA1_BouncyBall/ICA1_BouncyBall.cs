//*********************************************************************
//Program: ICA 1 - Bouncy Balls
//Files: Program.cs
// ICA1_BouncyBall.cs
// ICA1_BouncyBall.Designer.cs
// ICA1_BouncyBall.resx
// ICA1_Balls.cs
//Description: Generates random balls to bounce on the screen
//Version: 1.0
//Date: Sept 14, 2016
//Author: Ronald Mak
//Class: CMPE 2300
//Instructor: Simon Walker
//*********************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;


namespace ICA1_BouncyBall
{
    public partial class ICA1_BouncyBall : Form
    {
        private CDrawer _canvas = new CDrawer();                //Initialize global canvas to draw
        private List<CBall> _ballList = new List<CBall>();      //Iterate through list to draw each ball on canvas
        private Random rndNum = new Random();
        
        public ICA1_BouncyBall()
        {
            InitializeComponent();
            _canvas.ContinuousUpdate = false;
        }

        //Generate a random point where X != 0, Y != 0, X != Y
        private Point GetRandPos()
        {
            Point rndPos = new Point();

            do
            {
                rndPos.X = rndNum.Next(-5, 5);
                rndPos.Y = rndNum.Next(-5, 5);
            } while (rndPos.X == 0 || rndPos.Y == 0 || rndPos.X == rndPos.Y);

            return rndPos;
        }

        // Add a new ball into the list through leveraged constructor with color and direction
        private void B_RandBall_Click(object sender, EventArgs e)
        {
            _ballList.Add(new CBall(RandColor.GetColor(), GetRandPos()));
        }

        // Add a new ball into the list with regular constructor
        private void B_HyperBall_Click(object sender, EventArgs e)
        {
            _ballList.Add(new CBall(RandColor.GetColor()));
        }

        private void Bounce_Intrvl_Tick(object sender, EventArgs e)
        {
            _canvas.Clear();
            foreach (CBall ball in _ballList)
            {
                ball.Render(_canvas);
                _canvas.Render();
                ball.Move();
            }
        }
    }
}
