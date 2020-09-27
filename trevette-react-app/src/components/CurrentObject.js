import React, { Component } from 'react'
import ObjectGallery from './ObjectGallery'

export default class CurrentObject extends Component {
    render() {
        var mainphotourl = {
            backgroundImage: "url(gfx/inside-car.jpg)"
        };
        return (
            <div className="object">
                <div className="object__photo" style={mainphotourl}></div>
                <div className="object__info">
                    <div className="object__info--basic">
                        <h2>Porsche 911 Carrera</h2>
                        <span class="badge bg-yellow">V8 Motor</span>
                        <h4 className="flavor-title">Tidlös maskin</h4>
                        <p>Den nya porschen är riktigt fet. Har en 3 L motor och gör 100 km/h på 3.7 s med sport-chrono paket. Denna vagn är för dom riktigt rika. </p>
                        <div className="sale">
                            <button type="button" className="btn btn-success btn-lg btn-block">Förfråga om pris</button>
                            <h5 class="price">Uppskattat värde: 110000:-</h5>
                        </div>
                    </div>
                    <ObjectGallery />
                    <div className="object__info--technical">
                        <h4 className="title">Tidlös maskin</h4>
                    </div>
                </div>
            </div>
        )
    }
}
