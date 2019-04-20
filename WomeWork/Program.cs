using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//используем static System.Console что бы каждый раз не писать Сonsole.Writeline
using static System.Console;
using System.Threading;

namespace WomeWork {
    class Program {
        static void Main(string[] args) {
            //
            ConsoleKeyInfo keyinfo;
            //
            int leftPosition = 50, topPosition = 10;
            SetCursorPosition(leftPosition, topPosition);
            Write(".");
            int redlineLeft = 50-2, greenlineTop = 10-1,blueLineRight= 50+1, yellowLineDown = 10+1;

            new Action( () => {
                for (; ; ) {
                    if (redlineLeft > 0) {
                        ForegroundColor = ConsoleColor.Red;
                        SetCursorPosition(redlineLeft, topPosition);
                        Write("_");
                        redlineLeft--;
                    }
                    if (greenlineTop > 0) {
                        ForegroundColor = ConsoleColor.Green;
                        SetCursorPosition(leftPosition,greenlineTop);
                        Write("|");
                        greenlineTop--;

                    }
                    if(blueLineRight < 120) {
                        ForegroundColor = ConsoleColor.Blue;
                        SetCursorPosition(blueLineRight, topPosition);
                        Write("_");
                        blueLineRight++;
                    }
                    if (yellowLineDown < 28) {
                        ForegroundColor = ConsoleColor.Yellow;
                        SetCursorPosition(leftPosition, yellowLineDown);
                        Write("|");
                        yellowLineDown++;

                    }
                    Thread.Sleep(450);
                }

            } ).BeginInvoke(null,null);
            
            //
            for (; ; ) {
                keyinfo = ReadKey();
                if(keyinfo.Key == ConsoleKey.Escape) {
                    break;
                }                
            }
            
        }


    }
}
