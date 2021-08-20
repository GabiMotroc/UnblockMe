class radialTimePicker {
    constructor() {
        this.knobElm = (document.getElementById("knob"));

        this.knobElm.addEventListener("mousedown", e => {
            this.onGrab(e.clientX, e.clientY);
        });

        this.knobElm.addEventListener("mousemove", e => {
            this.onMove(e.clientX, e.clientY);
        });

        /*this.knobElm.addEventListener("mouseup", e => {
            this.onRelease(e);
        });*/

        this.currentAngle = 0;
        this.lastAngle = 0;
        this.lastAngles = [0, 0, 0];
        this.start = {
            x: this.knobElm.offsetWidth,
            y: this.knobElm.offsetHeight,
        };
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
        return Math.atan2(x, y) * 180 / Math.PI;
    }

}
let wheel = new radialTimePicker();

