import React, { Component } from 'react'

export default class ObjectGallery extends Component {
    render() {
        const objects = { };
        return (
            <div className="object__gallery">
                <div className="gallery-img" style={{backgroundImage: "url(gfx/cars/1/1.jpg)"}}></div>
                <div className="gallery-img" style={{backgroundImage: "url(gfx/cars/1/2.jpg)"}}></div>
                <div className="gallery-img" style={{backgroundImage: "url(gfx/cars/1/3.jpg)"}}></div>
            </div>
        )
    }
}
