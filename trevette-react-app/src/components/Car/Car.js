import React, { Component } from 'react'
import CarGallery from './CarGallery'
import SalesInfo from './SalesInfo/SalesInfo'

export default class Car extends Component {
    render() {
        var car = this.props.car;
        const isForSale = this.props.car.salesObject != null;
        var mainphotourl = {
            backgroundImage: "url(gfx/cars/1/1.jpg)"
        };
        return (
            <div className="object">
                <div className="object__photo" style={mainphotourl}></div>
                <div className="object__info">
                    <SalesInfo salesObject={car.salesObject} />
                    <div className="object__gallery">
                        <CarGallery photos={car.photos} carId={car.carId} />
                    </div>
                    <div className="object__info--technical">
                        <h4 className="title">Om bilen</h4>
                        <div className="box">
                            <div className="module module__noborder">
                                <div className="left"><span className="fa fa-car"></span><span>Modell:</span></div>
                                <div className="right">{car.model}</div>
                            </div>
                        </div>
                        <div className="box">
                            <div className="module module__noborder">
                                <div className="left"><span className="fa fa-car"></span><span>Årsmodell:</span></div>
                                <div className="right">{car.year}</div>
                            </div>
                        </div>
                        <div className="box">
                            <div className="module module__noborder">
                                <div className="left"><span className="fa fa-car"></span><span>Miltal:</span></div>
                                <div className="right">{car.mileage}</div>
                            </div>
                        </div>
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
