import React, { Component } from 'react'

import Cars from './Cars'

import axios from 'axios';
import './dashboard.css'

export default class Dashboard extends Component {
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
        return (
        <div className="page dashboard__main">
            <h1>Adminpanelen</h1>
            <p>Välkommen till din adminpanel. Alla bilar:</p>
            <Cars cars={this.state.cars} />
        </div>
        )
    }
}