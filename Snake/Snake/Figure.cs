﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake {
    class Figure {
        protected List<Point> pList = null;
        
        // virtual чтобы потомки могли переопределять с помощью ключевого слова override
        public virtual void Drow() {
            foreach (Point p in pList) {
                p.Draw();
            }
        }
    }
}
