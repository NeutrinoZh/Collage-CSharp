namespace Task2 {
    class Box {
        private int width;
        private int height;
        private int length;

        public int Width {
            get { return width; }
            set {
                if (value <= 0) {
                    Console.WriteLine("Была установлена единица");
                    width = 1;
                } else {
                    width = value;
                }
            }
        }
        public int Height {
            get { return height; }
            set {
                if (value <= 0) {
                    Console.WriteLine("Была установлена единица");
                    height = 1;
                } else {
                    height = value;
                }
            }
        }
        public int Length {
            get { return length; }
            set {
                if (value <= 0) {
                    Console.WriteLine("Была установлена единица");
                    length = 1;
                } else {
                    length = value;
                }
            }
        }

        public Box(int width, int height, int length) {
            this.Width = width;
            this.Height = height;
            this.Length = length;
        }

        public int Volume() {
            return Length * Height * Width;
        }

        public int LateralSurface() {
            return 2*Length*Height + 2*Width*Height;
        }

        public int Surface() {
            return 2*Length*Width + 2*Length*Height + 2*Width*Height;
        }
    }
}
