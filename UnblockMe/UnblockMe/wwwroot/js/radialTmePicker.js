class Wheel {
    constructor() {
        this.wheelElm = document.getElementById('wheel');
        this.iconElm = document.getElementById('icon');
        this.displayElm = document.getElementById('display');
        this.formPostElm = document.getElementById('durationSubmit');

        this.wheelElm.addEventListener('mousedown', e => {
            this.onGrab(e.clientX, e.clientY);
        });
        window.addEventListener('mousemove', e => {
            if (e.which == 1)
                this.onMove(e.clientX, e.clientY);
            else if (!this.isDragging)
                this.onRelease()

        });
        window.addEventListener('mouseup', this.onRelease.bind(this));

        this.wheelElm.addEventListener('touchstart', e => {
            this.onGrab(e.touches[0].clientX, e.touches[0].clientY);
        });
        window.addEventListener('touchmove', e => {
            this.onMove(e.touches[0].clientX, e.touches[0].clientY);
        });
        window.addEventListener('touchend', this.onRelease.bind(this));

        this.calculatePositions();
        window.addEventListener('resize', this.calculatePositions.bind(this));

        this.currentAngle = 0;
        this.oldAngle = 0;
        this.lastAngle = 0;
        this.isDragging = false;
        this.startX = null;
        this.startY = null;

    }

    calculatePositions() {
        this.wheelWidth = this.wheelElm.getBoundingClientRect()['width'];
        this.wheelHeight = this.wheelElm.getBoundingClientRect()['height']
        this.wheelX = this.wheelElm.getBoundingClientRect()['x'] + this.wheelWidth / 2;
        this.wheelY = this.wheelElm.getBoundingClientRect()['y'] + this.wheelHeight;
    }

    onGrab(x, y) {
        this.isDragging = true;

        var matches = this.wheelElm.style.transform.match(/(\d+)/);
        if (matches) {
            this.startAngle = 360 - matches[0] % 360;
            //console.log(360 - matches[0] % 360);
        }
        else {
            this.startAngle = this.calculateAngle(x, y);
        }
        //this.startAngle = parseInt (this.wheelElm.style.transform);
        //this.calculateAngle(x, y);
    }

    onMove(x, y) {
        if (!this.isDragging)
            return

        let deltaAngle = this.calculateAngle(x, y) - 180;


        this.currentAngle = deltaAngle;

        if (this.lastAngle > 330 && this.currentAngle < 180)
            this.currentAngle = 359.99;

        if (this.lastAngle < 30 && this.currentAngle > 180)
            this.currentAngle = 0.01;

        //console.log(deltaAngle);

        this.render(this.currentAngle);

        this.lastAngle = this.currentAngle;
    }

    onRelease() {
        if (this.isDragging) {
            this.isDragging = false;
            this.oldAngle = this.currentAngle;
        }
    }

    calculateAngle(currentX, currentY) {
        let xLength = currentX - this.wheelX;
        let yLength = currentY - this.wheelY;
        let angle = Math.atan2(xLength, yLength) * (180 / Math.PI);

        return 360 - angle;
    }

    calculateTime(deg) {
        if (deg <= 0.01)
            return "No Ban";
        if (deg >= 359.99)
            return "Permanent";
        if (deg > 0.01 && deg <= 120)
            return parseInt(deg / 5 + 1) + " hours";
        if (deg > 120 && deg < 240)
            return parseInt((deg - 120 ) / 4 + 1) + " days";
        if (deg >= 240)
            return parseInt((deg - 240) / 10 + 1) + " months";
    }

    render(deg) {
        this.wheelElm.style.transform = `rotate(${deg % 360}deg)`;
        this.iconElm.style.transform = `rotate(${360 - deg}deg`;
        this.displayElm.innerHTML = this.calculateTime(deg);
        this.formPostElm.value = this.calculateTime(deg);
    }

}

let wheel = new Wheel();