import { createSlice } from '@reduxjs/toolkit'

export const companySlice = createSlice({
  name: 'companys',
  initialState: {
    DATA: []
  },
  reducers: {
    sincronizeDataCompanys: (state, action) => {
        state.DATA = action.payload
    }
  }
})

// Action creators are generated for each case reducer function
export const { sincronizeDataCompanys } = companySlice.actions

export default companySlice.reducer