import React, { Component } from 'react'
import ObjectGallery from './ObjectGallery'

export default class CurrentObject extends Component {
    render() {
        var mainphotourl = {
            backgroundImage: "url(gfx/cars/1/1.jpg)"
        };
        return (
            <div className="object">
                <div className="object__photo" style={mainphotourl}></div>
                <div className="object__info">
                    <div className="object__info--basic">
                        <h2>Porsche 911 Carrera</h2>
                        <span class="badge bg-yellow">V8 Motor</span>
                        <span class="badge bg-yellow">Läderinredning</span>
                        <span class="badge bg-yellow">Specialobjekt</span>
                        <h4 className="flavor-title">Tidlös maskin</h4>
                        <p>Den nya porschen är riktigt fet. Har en 3 L motor och gör 100 km/h på 3.7 s med sport-chrono paket. Denna vagn är för dom riktigt rika. </p>
                        <div className="sale">
                            <button type="button" className="btn btn-lg btn-block">Förfråga om pris</button>
                        </div>
                    </div>
                    <ObjectGallery />
                    <div className="object__info--technical">
                        <h4 className="title">Tidlös maskin</h4>
                        <div className="box">
                            <div className="module">
                                <div className="left"><span class="fa fa-wrench"></span><span>Design och cylindrar</span></div>
                                <div className="right">Dubbel turbo</div>
                            </div>
                            <div className="module">
                                <div className="left"><span class="fas fa-stopwatch"></span><span>Acceleration</span></div>
                                <div className="right">3.5 sekunder 0-100 km/h</div>
                            </div>
                        </div>
                        <div className="box">
                            <div className="module">
                                <div className="left"><span class="fa fa-car-battery"></span><span>Motor</span></div>
                                <div className="right">V8 3.0L</div>
                            </div>
                            <div className="module">
                                <div className="left"><span class="fas fa-tachometer-alt"></span><span>Topphastighet</span></div>
                                <div className="right">200 km/h</div>
                            </div>
                        </div>
                        <div className="box">
                            <div className="module">
                                <div className="left"><span class="fa fa-arrows-alt-h"></span><span>Bredd</span></div>
                                <div className="right">185 cm</div>
                            </div>
                            <div className="module">
                                <div className="left"><span class="fas fa-gas-pump"></span><span>Tankvolym</span></div>
                                <div className="right">70 liter</div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        )
    }
}
