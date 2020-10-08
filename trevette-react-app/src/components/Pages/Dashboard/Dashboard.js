import React, { Component } from 'react'

import { BrowserRouter as Router, Route, Link } from 'react-router-dom';

import Cars from './Cars'
import CarDetails from './CarDetails'

import './dashboard.css'

export default class Dashboard extends Component {
    render() {
        return (
        <div className="page dashboard__main">
            <h1>Adminpanelen</h1>
            <p>Välkommen till din adminpanel.</p> 
            <Router>
              {/* Landing page */}
              <Route exact path="/Dashboard" render={props => (
                <DashboardMenuLinks />
              )} />
              {/* All cars */}
              <Route exact path="/Dashboard/Cars" render={props => (
                <React.Fragment>
                  <div className="dashboard__breadcrumbs">
                      <Link to="/Dashboard">Adminpanel</Link> &gt; <Link to="/Dashboard/Cars">Bilar</Link>
                  </div>
                  <Cars />
                </React.Fragment>
              )} />
              {/* Car by id */}
              <Route exact path="/Dashboard/Cars/:id" render={props => (
                <React.Fragment>
                  <CarDetails {...props } />
                </React.Fragment>
              )} />
            </Router>
        </div>
        )
    }
}

function DashboardMenuLinks() {
  return (
      <React.Fragment>
          <Link to="/Dashboard/Cars">Bilar</Link><br />
          <Link to="/Dashboard/SalesObject">Annonser</Link><br />
          <Link to="/Dashboard/Photos">Foton</Link><br />
      </React.Fragment>
  )
}