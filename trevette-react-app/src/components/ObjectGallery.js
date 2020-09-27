import React, { Component } from 'react'

export default class ObjectGallery extends Component {
    render() {
        const objects = { };
        return (
            <div className="object__gallery">
                <div className="gallery-img" style={{backgroundImage: "url(gfx/inside-car.jpg)"}}></div>
                <div className="gallery-img" style={{backgroundImage: "url(gfx/corvette-red.jpg)"}}></div>
                <div className="gallery-img" style={{backgroundImage: "url(gfx/corvette-yellow.jpg)"}}></div>
            </div>
        )
    }
}
