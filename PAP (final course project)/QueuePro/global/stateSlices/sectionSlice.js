import { createSlice } from '@reduxjs/toolkit'

export const sectionsSlice = createSlice({
  name: 'sections',
  initialState: {
    DATA: []
  },
  reducers: {
    sincronizeDataSections: (state, action) => {
      state.DATA = action.payload
    }
  }
})

// Action creators are generated for each case reducer function
export const { sincronizeDataSections } = sectionsSlice.actions

export default sectionsSlice.reducer