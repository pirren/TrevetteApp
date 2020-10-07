import React, { Component } from 'react'
import CarPhoto from './CarPhoto'

export default class CarGallery extends Component {
    render() {
        return this.props.photos.map((photo) => (
            <CarPhoto fileName={photo.fileName} carId={this.props.carId} />
        ))
    }
}
