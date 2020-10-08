import React, { Component } from 'react'

export default class SalesInfo extends Component {
    render() {
        const salesObject = this.props.salesObject;
        if(salesObject == null) {
            return (
            <div className="object__info--salesinfo">
                <p>Detta objekt är inte till salu</p>
            </div>
            );
        }
        else {
            return (
            <div className="object__info--salesinfo">
                <h2>{salesObject.title}</h2>
                <p>{salesObject.description}</p>
                <div className="sale">
                    <button type="button" className="btn btn-lg btn-block">Förfråga om pris</button>
                </div>
            </div>
            )
        }
    }
}
