import React, { Component } from 'react'

export default class Car extends Component {
    render() {
        return (
        <React.Fragment>
            <a href={"/Dashboard/Cars/"+this.props.car.carId}>{this.props.car.model}</a><br />
        </React.Fragment>
        )
    }
}
