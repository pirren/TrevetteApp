import React, { Component } from 'react'

export default class Garage extends Component {
    render() {
        return (
            <React.Fragment>
                <h2>Tidigare i Garaget</h2>
                <div className="module"  style={{backgroundImage: "url(gfx/car-blue.jpg)"}}>
                    
                </div>
                <div className="module"  style={{backgroundImage: "url(gfx/car-grey.jpg)"}}>
                    
                </div>
                <div className="module"  style={{backgroundImage: "url(gfx/car-black.jpg)"}}>
                    
                </div>
            </React.Fragment>
        )
    }
}
