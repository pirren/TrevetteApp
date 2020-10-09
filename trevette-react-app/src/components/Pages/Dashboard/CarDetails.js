import React, { Component } from 'react'
import { BrowserRouter as Router, Route, Link } from 'react-router-dom';

import { AppConfiguration } from "read-appsettings-json";

import axios from 'axios';

export default class CarDetails extends Component {
    constructor() {
        super();
        this.state = {
            carId: "",
            manufacturer : "",
            model: "",
            year: "",
            mileage: "",
            salesObject : "",
            photos: ""
        }
        this.handleChange = this.handleChange.bind(this);
    }


    componentDidMount() {
        axios.get(AppConfiguration.Setting().apiendpoint + 'Car/' + this.props.match.params.id)
        .then(res => { this.setState({
                carId: res.data.carId,
                manufacturer: res.data.manufacturer,
                model: res.data.model,
                year: res.data.year,
                mileage: res.data.mileage,
                salesObject: res.data.salesObject,
                photos: res.data.photos
            }) 
        })
        .catch(err => {console.log(err)}); 
    }

    handleChange = (evt) => {
        this.setState({[evt.target.name]: evt.target.value});
        console.log(evt.target.value);
    }

    handleSubmit = event => {
        event.preventDefault();

        let state = this.state;
        
        const car = {
            carId: state.carId,
            manufacturer: state.manufacturer,
            model: state.model,
            year: state.year,
            mileage: state.mileage
        };

        axios.put(AppConfiguration.Setting().apiendpoint + 'Car/' + state.carId, car)
            .then(res => {
                console.log(res);
                console.log(res.data);
            });
    }

    render() {
        const { match } = this.props;
        const id = this.props.match.params.id;
        // console.log(this.state);
        return (
            <React.Fragment>
                <div className="dashboard__breadcrumbs">
                    <Link to="/Dashboard">Adminpanel</Link> &gt; <Link to="/Dashboard/Cars">Bilar</Link> &gt; <Link to={"/Dashboard/Cars/" + id}>{match.params.id}</Link>
                </div>
                <h1>{this.state.model}</h1>
                <form onSubmit={this.handleSubmit}>
                    {/* Tillverkare */}
                    <div class="input-group input-group-sm mb-3">
                        <div class="input-group-prepend">
                            <span class="input-group-text" id="manufacturer-label">Tillverkare</span>
                        </div>
                        <input onChange={this, this.handleChange} type="text" name="manufacturer" class="form-control" value={this.state.manufacturer} aria-label="Manufacturer" aria-describedby="manufacturer-label" />
                    </div>
                    {/* Modell */}
                    <div class="input-group input-group-sm mb-3">
                        <div class="input-group-prepend">
                            <span class="input-group-text" id="model-label">Modell</span>
                        </div>
                        <input onChange={this, this.handleChange} type="text" name="model" class="form-control" value={this.state.model} aria-label="Modell" aria-describedby="model-label" />
                    </div>
                    {/* Årtal */}
                    <div class="input-group input-group-sm mb-3">
                        <div class="input-group-prepend">
                            <span class="input-group-text" id="year-label">Årtal</span>
                        </div>
                        <input onChange={this, this.handleChange} type="text" name="year" class="form-control" value={this.state.year} aria-label="Årtal" aria-describedby="year-label" />
                    </div>
                    {/* Miltal */}
                    <div class="input-group input-group-sm mb-3">
                        <div class="input-group-prepend">
                            <span class="input-group-text" id="mileage-label">Miltal</span>
                        </div>
                        <input onChange={this, this.handleChange} type="text" name="mileage" class="form-control" value={this.state.mileage} aria-label="Miltal" aria-describedby="mileage-label" />
                    </div>
                    <button type="submit" class="btn btn-success btn-lg btn-block">Uppdatera bil</button>
                </form>
            </React.Fragment>
        )
    }
}

