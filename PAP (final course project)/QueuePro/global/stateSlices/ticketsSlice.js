import { createSlice } from '@reduxjs/toolkit'

export const ticketsSlice = createSlice({
  name: 'tickets',
  initialState: {
    DATA: [],
    takedTicket: {}
  },
  reducers: {
    sincronizeDataTickets: (state, action) => {
        state.DATA = action.payload
    },
    sincronizeTakedTicket: (state, action) => {
        state.takedTicket = action.payload
    }
  }
})

// Action creators are generated for each case reducer function
export const { sincronizeDataTickets, sincronizeTakedTicket } = ticketsSlice.actions

export default ticketsSlice.reducer