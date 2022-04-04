namespace practic4 {
    class Spacecraft : Ship {
        private string planet { set; get; }
        public Spacecraft(string planet="Earth") {
            this.planet = planet;
        }
    }
}