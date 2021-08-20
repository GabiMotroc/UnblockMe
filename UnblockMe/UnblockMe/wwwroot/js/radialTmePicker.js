class radialTimePicker {
    constructor() {
        this.knobElm = (document.getElementById("knob"));

        this.knobElm.addEventListener("mousedown", e => {
            this.onGrab(e.clientX, e.clientY);
        });

        this.knobElm.addEventListener("mousemove", e => {
            if (e.which == 1)
                this.onMove(e.clientX, e.clientY);
            else if (!this.isDragging)
                this.onRelease()
        });

        window.addEventListener('mouseup', this.onRelease.bind(this));

        /*this.knobElm.addEventListener("mouseup", e => {
            this.onRelease(e);
        });*/

        this.calculatePositions();
        window.addEventListener('resize', this.calculatePositions.bind(this));

        this.currentAngle = 0;
        this.lastAngle = 0;
        this.lastAngles = [0, 0, 0];
        this.start = {
            x: null,
            y: null,
        };

        this.positionCallbacks = [];
    }

    calculatePositions() {
        this.wheelWidth = this.knobElm.getBoundingClientRect()['width'];
        this.wheelHeight = this.knobElm.getBoundingClientRect()['height']
        this.wheelX = this.knobElm.getBoundingClientRect()['x'] + this.wheelWidth / 2;
        this.wheelY = this.knobElm.getBoundingClientRect()['y'] + this.wheelHeight / 2;
    }

    onPositionChange(callback) {
        this.positionCallbacks.push(callback);
    }

    onRelease() {

        this.oldAngle = this.currentAngle;

    }

    onGrab(x, y) {
        this.startAngle = this.calculateAngleDegrees(x, y);
    }

    onMove(x, y) {

        this.currentAngle = this.calculateAngleDegrees(x, y);

        this.lastAngles.shift();
        this.lastAngles.push(this.currentAngle);

        let deltaAngle = this.calculateAngleDegrees(x, y) - this.startAngle;
        this.currentAngle = deltaAngle + this.oldAngle;

        this.render(this.currentAngle);
    }

    render(deg) {
        this.knobElm.style.transform = "rotate(" + deg + "deg)";
    }

    calculateAngleDegrees(x, y) {
        let xLength = x - this.wheelX;
        let yLength = y - this.wheelY;
        let angle = Math.atan2(xLength, yLength) * (180 / Math.PI);
        return 365 - angle;
    }

}
let wheel = new radialTimePicker();

