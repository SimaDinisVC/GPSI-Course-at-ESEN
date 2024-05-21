import { createSlice } from '@reduxjs/toolkit'

export const establishmentSlice = createSlice({
  name: 'establishments',
  initialState: {
    DATA: []
  },
  reducers: {
    sincronizeDataEstablishments: (state, action) => {
      state.DATA = action.payload
    }
  }
})

// Action creators are generated for each case reducer function
export const { sincronizeDataEstablishments } = establishmentSlice.actions

export default establishmentSlice.reducer