import React, { Component } from 'react'

import Car from './Car'
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
            <React.Fragment>
                <Car car={car} />
            </React.Fragment>
        ));
    }
}
