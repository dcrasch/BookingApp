const requestBookingsType = 'REQUEST_BOOKINGS';
const receiveBookingsType = 'RECEIVE_BOOKINGS';
const initialState = { bookings: [], 
  isLoading: false };

export const actionCreators = {
  requestBookings: startDateIndex => async (dispatch, getState) => {
      if (startDateIndex === getState().bookings.startDateIndex) {
      return;
    }

    dispatch({ type: requestBookingsType, startDateIndex });

    const url = `api/bookings/`;
    const response = await fetch(url);
    const bookings = await response.json();

    dispatch({ type: receiveBookingsType, startDateIndex, bookings });
  }
};

export const reducer = (state, action) => {
  state = state || initialState;

  if (action.type === requestBookingsType) {
    return {
      ...state,
      startDateIndex: action.startDateIndex,
      isLoading: true
    };
  }

  if (action.type === receiveBookingsType) {
    return {
      ...state,
      startDateIndex: action.startDateIndex,
      bookings: action.bookings,
      isLoading: false
    };
  }

  return state;
};
