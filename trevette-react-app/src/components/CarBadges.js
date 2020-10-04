import React, { Component } from 'react'
import Badge from './Badge'

export default class CarBadges extends Component {
    render() {
        const badges = ["V8 Motor", "Läderinredning" , "Specialobjekt" ];
        return badges.map((badge) => (
            <Badge badge={badge} />
        ));
    }
}
