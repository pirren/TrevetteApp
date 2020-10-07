import React, { Component } from 'react'
import Car from './Car'

export default class Cars extends Component {
    render() {
        return this.props.cars.map((car) => (
            <Car car={car} />
        ));
    }
}
