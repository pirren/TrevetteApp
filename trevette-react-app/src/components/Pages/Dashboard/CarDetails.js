import React, { Component } from 'react'
import { BrowserRouter as Router, Route, Link } from 'react-router-dom';

import axios from 'axios';

export default class CarDetails extends Component {
    constructor() {
        super();
        this.state = {
            car: ""
        }
        this.handleChange = this.handleChange.bind(this);
    }


    componentDidMount() {
        axios.get('https://localhost:44342/api/v1.0/Car/' + this.props.match.params.id)
        .then(res => { this.setState({car: res.data}) } )
        .catch(err => {console.log(err)}); 
    }

    handleChange = (evt) => {
        this.setState({[evt.target.name]: evt.target.value});
        console.log(evt.target.name);
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
                {/* Tillverkare */}
                <div class="input-group input-group-sm mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="manufacturer-label">Tillverkare</span>
                    </div>
                    <input onChange={this, this.handleChange} type="text" name="manufacturer" class="form-control" value={this.state.car.manufacturer} aria-label="Manufacturer" aria-describedby="manufacturer-label" />
                </div>
                {/* Modell */}
                <div class="input-group input-group-sm mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="model-label">Modell</span>
                    </div>
                    <input type="text" class="form-control" value={this.state.car.model} aria-label="Modell" aria-describedby="model-label" />
                </div>
                {/* Årtal */}
                <div class="input-group input-group-sm mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="year-label">Årtal</span>
                    </div>
                    <input type="text" class="form-control" value={this.state.car.year} aria-label="Årtal" aria-describedby="year-label" />
                </div>
                {/* Miltal */}
                <div class="input-group input-group-sm mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="mileage-label">Miltal</span>
                    </div>
                    <input type="text" class="form-control" value={this.state.car.mileage} aria-label="Miltal" aria-describedby="mileage-label" />
                </div>
            </React.Fragment>
        )
    }
}

