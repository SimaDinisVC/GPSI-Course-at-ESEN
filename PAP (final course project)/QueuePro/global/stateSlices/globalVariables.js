import { createSlice } from '@reduxjs/toolkit'

export const globalVariables = createSlice({
  name: 'globalVARS',
  initialState: {
  apiUrl: '10.1.21.32:4000',
    apiToken: 'HKR7Rw2HibLJAGEBZzpTb6QKr8uY5qtFoW5EMUb7cDApChjYCcBek0pWxT34mIW2ACL3TSjoWcPB8rKZhG7eh4yYQAF3DiYQW0levMGxgyo4oZ8cRL4JApRBfXmFZjMSvdHsYZx6k5xkA4xCHFjI9B',
    SelectedCompany: null,
    SelectedEstablishment: null,
  },
  reducers: {
    selectCompany: (state, action) => {
      return {
        ...state,
        SelectedCompany: action.payload,
      };
    },
    selectEstablishment: (state, action) => {
      return {
        ...state,
        SelectedEstablishment: action.payload,
      };
    }
  }
})

// Action creators are generated for each case reducer function
export const { selectCompany, selectEstablishment } = globalVariables.actions

export default globalVariables.reducer