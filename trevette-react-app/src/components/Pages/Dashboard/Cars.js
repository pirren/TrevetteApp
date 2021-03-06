import React, { Component } from 'react'
import { BrowserRouter as Router, Route, Link } from 'react-router-dom';

import axios from 'axios';

export default class Cars extends Component {
    constructor(props) {
        super(props);
        this.state = {
        cars: []
        }
    }

    componentDidMount() {
        axios.get('https://localhost:44342/api/v1.0/Car/')
        .then(res => { this.setState({cars: res.data}) } )
        .catch(err => {console.log(err)}); 
    }
    render() {
        return this.state.cars.map((car) => (
            <CarLink key={car.carId} car={car} />
        ));
    }
}

class CarLink extends Component {
    render() {
        return (
        <React.Fragment>
            <span className="fa fa-caret-right"></span> <Link to={"/Dashboard/Cars/"+this.props.car.carId}>{this.props.car.model}</Link><br />
        </React.Fragment>
        )
    }
}