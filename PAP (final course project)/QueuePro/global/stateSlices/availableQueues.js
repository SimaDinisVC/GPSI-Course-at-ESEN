import { createSlice } from '@reduxjs/toolkit'

export const availableQueues = createSlice({
  name: 'availableQueues',
  initialState: {
    DATA: []
  },
  reducers: {
    sincronizeQueues: (state, action) => {
        state.DATA = action.payload
    }
  }
})

// Action creators are generated for each case reducer function
export const { sincronizeQueues } = availableQueues.actions

export default availableQueues.reducer