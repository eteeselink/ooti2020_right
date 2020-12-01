using Spectre.Console;

namespace Kiosk {
    class DetailedResult {

        // static void Main(string[] args) {
        //     new DetailedResult().show();
        // }

        public void show(){
            // Create a canvas
            var canvas = new Canvas(16, 16);

            for(var i = 0; i < canvas.Width ; ++i) {
                for (var j = 0; j < canvas.Height; ++j){
                    if(i == 0){
                        canvas.SetPixel(i, j, Color.Green);
                    }
                    if(i == 2){
                        canvas.SetPixel(i, j, Color.Red);
                    }
                }
            }

            // Draw some shapes
            // for(var i = 0; i < canvas.Width; i++)
            // {
            //     // Cross
            //     canvas.SetPixel(i, i, Color.White);
            //     canvas.SetPixel(canvas.Width - i - 1, i, Color.White);

            //     // Border
            //     canvas.SetPixel(i, 0, Color.Red);
            //     canvas.SetPixel(0, i, Color.Green);
            //     canvas.SetPixel(i, canvas.Height - 1, Color.Blue);
            //     canvas.SetPixel(canvas.Width - 1, i, Color.Yellow);
            // }

            // Render the canvas
            AnsiConsole.Render(canvas);
        }   
    }

    class YesNoDetailedResult : DetailedResult {

        public void show(int noYes, int noNo){

            int size = noYes > noNo ? noYes : noNo;

            var canvas = new Canvas(8, size);

            for(var i = 0; i < canvas.Width ; ++i) {
                for (var j = 0; j < canvas.Height; ++j){
                    if(i == 3){
                        if(j > size - noYes){
                            canvas.SetPixel(i, j, Color.Green);
                        }
                    }
                    if(i == 7){
                        if(j > size - noNo){
                            canvas.SetPixel(i, j, Color.Red);
                        }
                    }
                }
            }

            AnsiConsole.Render(canvas);

            // Create a table
            var table = new Table();

            // Add some columns
            table.AddColumn("Yes ("+noYes+")");
            table.AddColumn("No ("+noNo+")");

            // Render the table to the console
            AnsiConsole.Render(table);
        }
    }

    class MultipleChoice : DetailedResult {
        public void show(int choices, int maxCount) {

        }
    }
}