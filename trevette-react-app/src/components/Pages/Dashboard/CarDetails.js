import React, { Component } from 'react'

export default class CarDetails extends Component {
    render() {
        const { match } = this.props;
        const id = match.params.id;
        return (
            <div className="dashboard__breadcrumbs">
                <a href="/Dashboard">Adminpanel</a> &gt; <a href="/Dashboard/Cars">Bilar</a> &gt; <a href={"/Dashboard/Cars/" + id}>{match.params.id}</a>
            </div>
        )
    }
}


