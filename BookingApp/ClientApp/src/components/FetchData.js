import React, { Component } from 'react';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import { Link } from 'react-router-dom';
import { actionCreators } from '../store/Bookings';

class FetchData extends Component {
  componentWillMount() {
    // This method runs when the component is first added to the page
    const startDateIndex = parseInt(this.props.match.params.startDateIndex, 10) || 0;
    this.props.requestBookings(startDateIndex);
  }

  componentWillReceiveProps(nextProps) {
    // This method runs when incoming props (e.g., route params) change
    const startDateIndex = parseInt(nextProps.match.params.startDateIndex, 10) || 0;
    this.props.requestBookings(startDateIndex);
  }

  render() {
    return (
      <div>
        <h1>Booking</h1>
        {renderBookingTable(this.props)}
        {renderPagination(this.props)}
      </div>
    );
  }
}

function renderBookingTable(props) {
  return (
    <table className='table'>
      <thead>
        <tr>
          <th>ID</th>
          <th>Name</th>
        </tr>
      </thead>
      <tbody>
        {props.bookings.map(booking =>
          <tr key={booking.id}>
            <td>{booking.id}</td>
            <td>{booking.name}</td>
          </tr>
        )}
      </tbody>
    </table>
  );
}

function renderPagination(props) {
  const prevStartDateIndex = (props.startDateIndex || 0) - 5;
  const nextStartDateIndex = (props.startDateIndex || 0) + 5;

  return <p className='clearfix text-center'>
    <Link className='btn btn-default pull-left' to={`/fetchdata/${prevStartDateIndex}`}>Previous</Link>
    <Link className='btn btn-default pull-right' to={`/fetchdata/${nextStartDateIndex}`}>Next</Link>
    {props.isLoading ? <span>Loading...</span> : []}
  </p>;
}

export default connect(
  state => state.bookings,
  dispatch => bindActionCreators(actionCreators, dispatch)
)(FetchData);
