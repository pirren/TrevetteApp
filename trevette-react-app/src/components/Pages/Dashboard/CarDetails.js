import React, { Component } from 'react'
import { BrowserRouter as Router, Route, Link } from 'react-router-dom';

import axios from 'axios';

export default class CarDetails extends Component {
    constructor(props) {
        super(props);
        this.state = {
            car: ""
        }
    }

    componentDidMount() {
        axios.get('https://localhost:44342/api/v1.0/Car/' + this.props.match.params.id)
        .then(res => { this.setState({car: res.data}) } )
        .catch(err => {console.log(err)}); 
    }

    render() {
        const { match } = this.props;
        const id = this.props.match.params.id;
        return (
            <React.Fragment>
                <div className="dashboard__breadcrumbs">
                    <Link to="/Dashboard">Adminpanel</Link> &gt; <Link to="/Dashboard/Cars">Bilar</Link> &gt; <Link to={"/Dashboard/Cars/" + id}>{match.params.id}</Link>
                </div>
                <h1>{this.state.car.model}</h1>

                <div class="input-group input-group-sm mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="inputGroup-sizing-sm">Modell</span>
                    </div>
                    <input type="text" class="form-control" value={this.state.car.model} aria-label="Modell" aria-describedby="inputGroup-sizing-sm" />
                </div>
            </React.Fragment>
        )
    }
}


