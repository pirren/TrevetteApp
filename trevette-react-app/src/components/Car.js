import React, { Component } from 'react'
import CarGallery from './CarGallery'
import CarBadges from './CarBadges'

export default class Car extends Component {
    render() {
        var mainphotourl = {
            backgroundImage: "url(gfx/cars/1/1.jpg)"
        };
        var car = this.props.car;
        return (
            <div className="object">
                <div className="object__photo" style={mainphotourl}></div>
                <div className="object__info">
                    <div className="object__info--basic">
                        <h2>{car.model}</h2>
                        <CarBadges badges={car.badges} />
                        <h4 className="flavor-title">{car.title}</h4>
                        <p>{car.description}</p>
                        <div className="sale">
                            <button type="button" className="btn btn-lg btn-block">Förfråga om pris</button>
                        </div>
                    </div>
                    <CarGallery />
                    <div className="object__info--technical">
                        <h4 className="title">Tekniska detaljer</h4>
                        <div className="box">
                            <div className="module">
                                <div className="left"><span className="fa fa-wrench"></span><span>Design och cylindrar</span></div>
                                <div className="right">Dubbel turbo</div>
                            </div>
                            <div className="module">
                                <div className="left"><span className="fas fa-stopwatch"></span><span>Acceleration</span></div>
                                <div className="right">3.5 sekunder 0-100 km/h</div>
                            </div>
                        </div>
                        <div className="box">
                            <div className="module">
                                <div className="left"><span className="fa fa-car-battery"></span><span>Motor</span></div>
                                <div className="right">V8 3.0L</div>
                            </div>
                            <div className="module">
                                <div className="left"><span className="fas fa-tachometer-alt"></span><span>Topphastighet</span></div>
                                <div className="right">200 km/h</div>
                            </div>
                        </div>
                        <div className="box">
                            <div className="module">
                                <div className="left"><span className="fa fa-arrows-alt-h"></span><span>Bredd</span></div>
                                <div className="right">185 cm</div>
                            </div>
                            <div className="module">
                                <div className="left"><span className="fas fa-gas-pump"></span><span>Tankvolym</span></div>
                                <div className="right">70 liter</div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        )
    }
}
