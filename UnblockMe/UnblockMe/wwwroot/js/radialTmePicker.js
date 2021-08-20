class Wheel {
    constructor() {
        this.wheelElm = document.getElementById('wheel');
        this.iconElm = document.getElementById('icon');
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
        this.startAngle = this.calculateAngle(x, y);
    }

    onMove(x, y) {
        if (!this.isDragging)
            return

        let deltaAngle = this.calculateAngle(x, y) - this.startAngle;
        this.currentAngle = deltaAngle + this.oldAngle;

        this.render(this.currentAngle);
    }

    calculateAngle(currentX, currentY) {
        let xLength = currentX - this.wheelX;
        let yLength = currentY - this.wheelY;
        let angle = Math.atan2(xLength, yLength) * (180 / Math.PI);

        console.log(360 - angle);

        //if (360 - angle < 240)
        //    return 240;
        //if (360 - angle > 480)
        //    return 480;

        return 365 - angle;
    }

    onRelease() {
        if (this.isDragging) {
            this.isDragging = false;
            this.oldAngle = this.currentAngle;
        }
    }

    render(deg) {
        this.wheelElm.style.transform = `rotate(${deg}deg)`;
        this.iconElm.style.transform = `rotate(${360 - deg}deg`;
    }
}

let wheel = new Wheel();