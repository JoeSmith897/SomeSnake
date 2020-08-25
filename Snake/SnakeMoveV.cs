﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Snake {
    class SnakeMoveV{
        private List<Point> pList;
        private Point p;
        public SnakeMoveV(int x, int leftY, int rightY, char sym) {

            pList = new List<Point>();

            for (int y = leftY; y <= rightY; y++) {
                p = new Point(x, y, sym);
                pList.Add(p);
            }

        }

        public void getLine() {
            foreach (Point p in pList) {
                p.getPoint();
            }
        }
    }
}