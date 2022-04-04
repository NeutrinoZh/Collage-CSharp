namespace practic4 {
    class Ship {
        private float x { set; get; }
        private float y { set; get; }

        private string title { set; get; }
        private float maxSpeed { set; get; }
        private float hullLength { set; get; }
        private int teamSize { set; get; }
        
        public Ship(
            float x=0, float y=0,
            string title="Ship",
            float maxSpeed=100,
            float hullLength=10,
            int teamSize=8
        ) {
            this.x = x;
            this.y = y;
            this.title = title;
            this.maxSpeed = maxSpeed;
            this.hullLength = hullLength;
            this.teamSize = teamSize;
        }

        public void moveUp() {
            this.y++;
        }

        public float getTeamSize() {
            return this.teamSize;
        }

        public float getHullLength() {
            return this.hullLength;
        }

        public float getMaxSpeed() {
            return maxSpeed;
        }

        public string getTitle() {
            return title;
        }

        public float getX() {
            return this.x;
        }
        public float getY() {
            return this.y;
        }
    }
}