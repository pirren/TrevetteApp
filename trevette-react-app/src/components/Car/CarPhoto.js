import React, { Component } from 'react'

export default class CarPhoto extends Component {
    render() {
        const imgUrl = 'https://localhost:44342/Photos/Cars/'
            +this.props.carId
            +'/'
            +this.props.fileName;
        const photoStyle = {
            backgroundImage: 'url('+imgUrl+')'
        };
        return (
            <div className="gallery-img" style={photoStyle}></div>
            // <div className="gallery-img" style={{backgroundImage: "url(gfx/cars/1/2.jpg)"}}></div>
            // <div className="gallery-img" style={{backgroundImage: "url(gfx/cars/1/3.jpg)"}}></div>
        )
    }
}
