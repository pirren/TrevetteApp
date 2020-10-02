import React, { Component } from 'react'
import Badge from './Badge'

export default class CarBadges extends Component {
    render() {
        return this.props.badges.map((badge) => (
            <Badge badge={badge} />
        ));
    }
}
