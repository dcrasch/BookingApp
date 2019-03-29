import React from 'react';
import { Route } from 'react-router';
import Layout from './components/Layout';
import Home from './components/Home';
import FetchData from './components/FetchData';

export default () => (
  <Layout>
    <Route exact path='/' component={Home} />
    <Route path='/fetchdata/:startDateIndex?' component={FetchData} />
  </Layout>
);
