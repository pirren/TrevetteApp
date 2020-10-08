import React, { Component } from 'react'

export default class Car extends Component {
    render() {
        return (
        <React.Fragment>
            <h6>{this.props.car.model}</h6>
        </React.Fragment>
        )
    }
}
