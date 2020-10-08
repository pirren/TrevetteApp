import React, { Component } from 'react'

import { BrowserRouter as Router, Route } from 'react-router-dom';

import Cars from './Cars'
import DashboardMenuLinks from './DashboardMenuLinks'

import './dashboard.css'

export default class Dashboard extends Component {
    render() {
        return (
        <div className="page dashboard__main">
            <h1>Adminpanelen</h1>
            <p>Välkommen till din adminpanel.</p> 
            <Router>
              <Route exact path="/Dashboard" render={props => (
                <DashboardMenuLinks />
              )} />
              <Route path="/Dashboard/Cars" render={props => (
                <React.Fragment>
                  <div className="dashboard__breadcrumbs">
                    <a href="/Dashboard">Adminpanel</a> &gt; <a href="/Dashboard/Cars">Bilar</a>
                  </div>
                  <Cars />
                </React.Fragment>
              )} />
            </Router>
        </div>
        )
    }
}