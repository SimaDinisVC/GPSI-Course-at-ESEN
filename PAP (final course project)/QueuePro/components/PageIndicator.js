import {StyleSheet, View} from 'react-native';

export default function PageIndicator ({ pageCount, currentPage }) {
    return (
      <View style={styles.pageIndicatorContainer}>
        {[...Array(pageCount).keys()].map((index) => (
          <View
            key={index}
            style={[
              styles.pageIndicator,
              index === currentPage ? styles.currentPageIndicator : null,
            ]}
          />
        ))}
      </View>
    );
};

const styles = StyleSheet.create({
    // Outros estilos...
    pageIndicatorContainer: {
      flexDirection: 'row',
      justifyContent: 'center',
      alignItems: 'center',
      marginTop: 10,
    },
    pageIndicator: {
      width: 8,
      height: 8,
      borderRadius: 4,
      backgroundColor: '#888',
      marginHorizontal: 4,
    },
    currentPageIndicator: {
      backgroundColor: '#305e96',
    },
});