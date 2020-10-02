import React, { Component } from 'react'

export default class Badge extends Component {
    render() {
        return (
            <span className="badge bg-yellow">{this.props.badge.title}</span>
        )
    }
}
