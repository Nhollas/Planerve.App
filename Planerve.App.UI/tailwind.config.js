module.exports = {
  content: [
    // Example content paths...
    "./Areas/*/Views/*/*.cshtml",
    "./Views/Shared/_*.cshtml",
  ],
  theme: {
    extend: {
      maxWidth: {
        'mobile' : '',
      },
      fontFamily: {
        link: ["Raleway", "sans-serif"],
        poppins: ["Poppins", "sans-serif"],
      },
    },
  },
  plugins: [],
};
