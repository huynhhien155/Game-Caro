﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            #region Properties
            ChessBoardManager ChessBoard;
            #endregion
            InitializeComponent();

            ChessBoard = new ChessBoardManager(pnlChessBoard,txbPlayerName,pctbMark);

            ChessBoard.DrawChessBoard();
        }  
    }
}
